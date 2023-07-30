using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HMS_Data_Layer.HMS_IData;
using HMS_Data_Layer.HMS_Data;
using HMS_View_Models.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace HMS_Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ApplicationController
    {
        private IUser userManager;
        public UserController()
        {
            userManager = new User();
        }

        [HttpPost("Login")]
        public async Task<string> Login([FromQuery] UserLoginModel loginModel)
        {
            List<UserRoleMenuModel> menulist = new List<UserRoleMenuModel>();
            List<UserRoleMenuModel> menuAcceslist = new List<UserRoleMenuModel>();
            if (ModelState.IsValid)
            {
                bool AuthenticateUser = false;
                string hashpaswdfromdb = await userManager.AuthenticateUser(loginModel);
                if (!string.IsNullOrEmpty(hashpaswdfromdb))
                {
                    AuthenticateUser = PasswordHasher.VerifyPassword(loginModel.Password , hashpaswdfromdb);
                }

                if (AuthenticateUser == true)
                {
                    AppUserRoleModel appuserRoleInfo = await userManager.GetUserbyusidAndPaswd(loginModel.UserId, hashpaswdfromdb);
                    if (appuserRoleInfo != null)
                    {
                        UserContext context = new UserContext();
                        context.AppUserId = appuserRoleInfo.AppUserID;
                        context.Role_Id = appuserRoleInfo.Role_Id;
                        context.AppUserName = appuserRoleInfo.AppUserName;
                        context.RoleName = appuserRoleInfo.AppRoleName;
                        context.isAuthenticated = AuthenticateUser;
                        context.LastLoginTime = DateTime.UtcNow;
                        HttpContext.Session.SetString("UserSession", JsonConvert.SerializeObject(context));
                        menulist = await userManager.GetAllMenusBasedOnRoleId(context.Role_Id.HasValue ? context.Role_Id.Value : 0);
                        HttpContext.Session.SetString("UserMenus", JsonConvert.SerializeObject(menulist));
                        menuAcceslist = await userManager.GetAllMenuAccessListOnRoleId(context.Role_Id.HasValue ? context.Role_Id.Value : 0);
                        HttpContext.Session.SetString("UserAccesMenus", JsonConvert.SerializeObject(menuAcceslist));
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.NameIdentifier, loginModel.UserId),
                            new Claim(ClaimTypes.Name, context.AppUserName),
                            //new Claim(ClaimTypes.Email, user.Email),
                            new Claim(ClaimTypes.Role, context.RoleName)
                        };

                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);

                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        HttpContext.User = principal;
                    }
                }
            }
            var x = GetJsonData(menulist);
            return await Task.Run(()=> x); //JsonConvert.SerializeObject(menuAcceslist).ToString();
        }

        public static class PasswordHasher
        {
            public static string HashPassword(string password)
            {
                byte[] salt = new byte[128 / 8];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }

                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));

                return $"{Convert.ToBase64String(salt)}:{hashed}";
            }

            public static bool VerifyPassword(string password, string hashedPassword)
            {
                string[] parts = hashedPassword.Split(':', 2);
                byte[] salt = Convert.FromBase64String(parts[0]);
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));

                return hashed == parts[1];
            }
        }
    }
}
