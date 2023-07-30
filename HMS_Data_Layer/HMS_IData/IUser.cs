using HMS_View_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Data_Layer.HMS_IData
{
    public interface IUser : IDisposable
    {
        Task<string> AuthenticateUser(UserLoginModel loginModel);

        Task<AppUserRoleModel> GetUserbyusidAndPaswd(string UserId, string Password);
        Task<List<UserModel>> GetAllUsers();
        Task<UserModel> GetUserbyId(int AppUserId);
        Task<bool> DeleteAppUser(int AppuserId);
        Task<bool> AddNewAppUser(UserModel model, UserContext userContext);

        Task<bool> AddNewRole(UserRoleModel model, UserContext userContext);
        Task<List<UserRoleModel>> GetAllRoles();
        Task<UserRoleModel> GetRolebyId(int RoleId);

        Task<bool> DeleteRole(int RoleId);

        Task<bool> MapNewUserRole(AppUserRoleModel model);
        Task<List<AppUserRoleModel>> GetAllAppUserRoles();
        Task<bool> DeleteAppUserRole(int AppUsrRoleId);

        Task<List<UserRoleMenuModel>> GetAllMenusBasedOnRoleId(int Role_Id);
        Task<List<UserRoleMenuModel>> GetAllMenuAccessListOnRoleId(int Role_Id);
        Task<bool> SaveRoleAccessMenus(List<UserRoleMenuModel> menus);
    }
}
