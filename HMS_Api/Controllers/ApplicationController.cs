using HMS_Data_Layer.HMS_Data;
using HMS_Data_Layer.HMS_IData;
using HMS_View_Models;
using HMS_View_Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection.PortableExecutable;
using System.Text.Json;

namespace HMS_Api.Controllers
{
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private IUser userManager;
        public ApplicationController()
        {
            userManager = new User();
        }

        public UserContext userContext
        {
            get
            {
                if (HttpContext.Session.TryGetValue("UserSession", out _))
                {
                    return JsonConvert.DeserializeObject<UserContext>(HttpContext.Session.GetString("UserSession"));
                }
                else
                {
                    return new UserContext();
                }
            }
        }

        public List<UserRoleMenuModel> MenuListBasedOnRoleId
        {
            get
            {
                if (HttpContext.Session.TryGetValue("UserMenus", out _))
                {
                    return JsonConvert.DeserializeObject<List<UserRoleMenuModel>>(HttpContext.Session.GetString("UserMenus"));
                }
                else
                {
                    return new List<UserRoleMenuModel>();
                }
            }
        }

        public List<UserRoleMenuModel> MenuAccessListBasedOnRoleId
        {
            get
            {
                if (HttpContext.Session.TryGetValue("UserAccesMenus", out _))
                {
                    return JsonConvert.DeserializeObject<List<UserRoleMenuModel>>(HttpContext.Session.GetString("UserAccesMenus"));
                }
                else
                {
                    return new List<UserRoleMenuModel>();
                }
            }
        }

        public async Task<string> GetJsonData<T>(T data)
        {
            Header head = new Header();
            head.menulist = await userManager.GetAllMenusBasedOnRoleId(userContext.Role_Id.HasValue ? userContext.Role_Id.Value : 0);
            head.userContext = userContext;
            if (data != null)
            {

            }
            Dictionary<string, object> jsonData = new Dictionary<string, object>
            {
                { "header", head },
                { "data", data }
            };
            string jsonString = System.Text.Json.JsonSerializer.Serialize(jsonData, new JsonSerializerOptions
            {
                WriteIndented = true // Optional: For pretty formatting
            });
            return jsonString;
        }
    }
}
