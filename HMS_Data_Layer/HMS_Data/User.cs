using HMS_Data_Layer.HMS_IData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using HMS_View_Models.Models;
using Microsoft.EntityFrameworkCore;
using HMS_Data_Layer.DBContext;

namespace HMS_Data_Layer.HMS_Data
{
    public class User:IUser
    {
        public HMS_Api_DbContext context;
        public User()
            : this(new HMS_Api_DbContext())
        {
        }
        public User(HMS_Api_DbContext context)
        {
            this.context = context;
        }

        public async Task<string> AuthenticateUser(UserLoginModel loginModel)
        {
            string? Paswd = string.Empty;
            try
            {
                Paswd = await context.HmsAppUsers.AsNoTracking().Where(a => a.IsActive == 1 && a.UserId == loginModel.UserId).Select(s => s.Password).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
            if (Paswd != null)
                return await Task.Run(() => Paswd);
            else
                return String.Empty;
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    return await (from appuser in context.HmsAppUsers.AsNoTracking().Where(a => a.IsActive == 1)
                                  select new UserModel
                                  {
                                      AppUserId = appuser.AppUserId,
                                      UserId = appuser.UserId,
                                      EmailId = appuser.EmailId,
                                      MobileNumber = appuser.PhoneNumber,
                                      FirstName = appuser.FirstName,
                                      LastName = appuser.LastName,
                                      IsActive = Convert.ToBoolean(appuser.IsActive),
                                      RegisterDate = appuser.CreatedDate
                                  }).ToListAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteAppUser(int AppuserId)
        {
            bool IsDeleted = false;
            int result = 0;
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    HmsAppUser? apusr = context.HmsAppUsers.Where(a => a.AppUserId == AppuserId && a.IsActive == 1).FirstOrDefault();
                    if (apusr != null)
                    {
                        apusr.IsActive = 0;
                        apusr.UpdatedDate = DateTime.Now;
                        apusr.UpdatedBy = AppuserId;
                        context.Entry(apusr).State = EntityState.Modified;
                        context.SaveChanges();
                        result = 1;
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
            if (result != 0)
            {
                IsDeleted = true;
            }
            return await Task.Run(() => IsDeleted);
        }


        public async Task<AppUserRoleModel> GetUserbyusidAndPaswd(string UserId, string Password)
        {
            AppUserRoleModel? user = new AppUserRoleModel();
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    user = await (from apusr in context.HmsAppUsers.AsNoTracking().Where(a => a.IsActive == 1 && a.UserId == UserId && a.Password == Password)
                                  join apusrrole in context.HmsAppUserRoles.AsNoTracking().Where(r => r.IsActive == 1) on apusr.AppUserId equals apusrrole.AppUserId
                                  join roles in context.HmsRoles.AsNoTracking().Where(r => r.IsActive == 1) on apusrrole.RoleId equals roles.RoleId
                                  select new AppUserRoleModel
                                  {
                                      Role_Id = apusrrole.RoleId,
                                      AppUserRole_Id = apusrrole.AppUserRoleId,
                                      AppUserID = apusrrole.AppUserId,
                                      AppUserName = apusr.FirstName + " " + apusr.LastName,
                                      AppRoleName = roles.RoleName,
                                  }).FirstOrDefaultAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (user != null)
            {
                return await Task.Run(() => user);
            }
            else
            {
                return new AppUserRoleModel();
            }

        }


        public async Task<UserModel> GetUserbyId(int AppUserId)
        {
            UserModel? user = new UserModel();
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    user = await (from apusr in context.HmsAppUsers.AsNoTracking().Where(a => a.IsActive == 1 && a.AppUserId == AppUserId)
                                  select new UserModel
                                  {
                                      AppUserId = apusr.AppUserId,
                                      UserId = apusr.UserId,
                                      Password = apusr.Password,
                                      EmailId = apusr.EmailId,
                                      MobileNumber = apusr.PhoneNumber,
                                      FirstName = apusr.FirstName,
                                      LastName = apusr.LastName,
                                      RegisterDate = apusr.CreatedDate
                                  }).FirstOrDefaultAsync();
                }

            }
            catch (Exception)
            {

                throw;
            }
            if (user != null)
            {
                return await Task.Run(() => user);
            }
            else
            {
                return new UserModel();
            }

        }

        public async Task<bool> AddNewAppUser(UserModel model, UserContext userContext)
        {
            bool IsAdded = false;
            int result = 0;
            try
            {
                if (model != null)
                {
                    using (var context = new HMS_Api_DbContext())
                    {
                        int count = context.HmsAppUsers.AsNoTracking().Where(a => a.UserId == model.UserId && a.AppUserId != model.AppUserId).Count();
                        if (count == 0)
                        {
                            if (model.AppUserId > 0)
                            {
                                HmsAppUser? usr = context.HmsAppUsers.Where(a => a.AppUserId == model.AppUserId && a.IsActive == 1).FirstOrDefault();
                                if (usr != null)
                                {
                                    usr.UserId = model.UserId;
                                    usr.Password = model.HashPassword;
                                    usr.EmailId = model.EmailId;
                                    usr.PhoneNumber = model.MobileNumber;
                                    usr.FirstName = model.FirstName;
                                    usr.LastName = model.LastName;
                                    usr.UpdatedDate = DateTime.Now;
                                    usr.UpdatedBy = userContext.AppUserId;
                                    usr.IsActive = 1;
                                }
                                context.Entry(usr).State = EntityState.Modified;
                                await context.SaveChangesAsync();
                                result = 1;
                            }
                            else
                            {

                                HmsAppUser usr = new HmsAppUser
                                {
                                    UserId = model.UserId,
                                    Password = model.HashPassword,
                                    EmailId = model.EmailId,
                                    PhoneNumber = model.MobileNumber,
                                    FirstName = model.FirstName,
                                    LastName = model.LastName,
                                    IsActive = 1,
                                    CreatedBy = userContext.AppUserId,
                                    CreatedDate = DateTime.Now
                                };
                                context.HmsAppUsers.Add(usr);
                                context.Entry(usr).State = EntityState.Added;
                                await context.SaveChangesAsync();
                                result = 1;

                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }

            if (result != 0)
            {
                IsAdded = true;
            }
            return await Task.Run(() => IsAdded);

        }


        public async Task<bool> AddNewRole(UserRoleModel model, UserContext userContext)
        {
            bool IsAdded = false;
            int result = 0;
            try
            {
                if (model != null)
                {
                    using (var context = new HMS_Api_DbContext())
                    {
                        int count = context.HmsRoles.AsNoTracking().Where(a => a.RoleName == model.RoleName && a.RoleId != model.Role_Id).Count();
                        if (count == 0)
                        {
                            if (model.Role_Id > 0)
                            {
                                HmsRole? rol = context.HmsRoles.Where(a => a.RoleId == model.Role_Id && a.IsActive == 1).FirstOrDefault();
                                if (rol != null)
                                {
                                    rol.RoleName = model.RoleName;
                                    rol.RoleDescription = model.RoleDescription;
                                    rol.IsActive = 1;
                                    rol.UpdatedDate = DateTime.Now;
                                    rol.UpdatedBy = userContext.AppUserId;
                                    context.Entry(rol).State = EntityState.Modified;
                                    await context.SaveChangesAsync();
                                    result = 1;
                                }

                            }
                            else
                            {
                                HmsRole rol = new HmsRole
                                {
                                    RoleName = model.RoleName,
                                    RoleDescription = model.RoleDescription,
                                    IsActive = 1,
                                    CreatedDate = DateTime.Now,
                                    CreatedBy = userContext.AppUserId.Value
                                };
                                context.HmsRoles.Add(rol);
                                context.Entry(rol).State = EntityState.Added;
                                await context.SaveChangesAsync();
                                result = 1;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            if (result != 0)
            {
                IsAdded = true;
            }
            return await Task.Run(() => IsAdded);

        }

        public async Task<List<UserRoleModel>> GetAllRoles()
        {
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    return await (from rol in context.HmsRoles.AsNoTracking().Where(a => a.IsActive == 1)
                                  select new UserRoleModel
                                  {
                                      Role_Id = rol.RoleId,
                                      RoleName = rol.RoleName,
                                      RoleDescription = rol.RoleDescription,
                                      IsActive = rol.IsActive
                                  }).ToListAsync();
                }

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<UserRoleModel> GetRolebyId(int RoleId)
        {
            DataSet ds = new DataSet();
            UserRoleModel? role = new UserRoleModel();
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    role = await (from rol in context.HmsRoles.AsNoTracking().Where(a => a.IsActive == 1 && a.RoleId == RoleId)
                                  select new UserRoleModel
                                  {
                                      Role_Id = rol.RoleId,
                                      RoleName = rol.RoleName,
                                      RoleDescription = rol.RoleDescription,
                                      IsActive = rol.IsActive
                                  }).FirstOrDefaultAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return await Task.Run(() => role);
        }

        public async Task<bool> DeleteRole(int RoleId)
        {
            bool IsDeleted = false;
            int result = 0;
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    HmsRole? rol = context.HmsRoles.Where(a => a.RoleId == RoleId && a.IsActive == 1).FirstOrDefault();
                    if (rol != null)
                    {
                        rol.IsActive = 0;
                        rol.UpdatedDate = DateTime.Now;
                        context.Entry(rol).State = EntityState.Modified;
                        await context.SaveChangesAsync();
                        result = 1;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            if (result != 0)
            {
                IsDeleted = true;
            }
            return await Task.Run(() => IsDeleted);
        }


        public async Task<List<AppUserRoleModel>> GetAllAppUserRoles()
        {
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    return await (from apusrrol in context.HmsAppUserRoles.AsNoTracking().Where(a => a.IsActive == 1)
                                  join apusr in context.HmsAppUsers.Where(a => a.IsActive == 1) on apusrrol.AppUserId equals apusr.AppUserId into apusrset
                                  from defapusr in apusrset.DefaultIfEmpty()
                                  join rol in context.HmsRoles.Where(a => a.IsActive == 1) on apusrrol.RoleId equals rol.RoleId into rolset
                                  from defrol in rolset.DefaultIfEmpty()
                                  select new AppUserRoleModel
                                  {
                                      Role_Id = apusrrol.RoleId,
                                      AppUserRole_Id = apusrrol.AppUserRoleId,
                                      AppUserID = apusrrol.AppUserId,
                                      AppUserName = defapusr.FirstName + " " + defapusr.LastName,
                                      AppRoleName = defrol.RoleName
                                  }).ToListAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<bool> MapNewUserRole(AppUserRoleModel model)
        {
            bool IsAdded = false;
            int result = 0;
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    int count = context.HmsAppUserRoles.AsNoTracking().Where(a => a.AppUserId == model.AppUserID && a.AppUserRoleId != model.AppUserRole_Id).Count();
                    if (count == 0)
                    {
                        if (model.AppUserRole_Id > 0)
                        {
                            HmsAppUserRole? aprl = context.HmsAppUserRoles.AsNoTracking().Where(a => a.AppUserRoleId == model.AppUserRole_Id && a.IsActive == 1).FirstOrDefault();
                            if (aprl != null)
                            {
                                aprl.RoleId = model.Role_Id;
                                aprl.AppUserId = model.AppUserID;
                                aprl.IsActive = 1;
                                aprl.UpdatedBy = model.AppUserID;
                                aprl.UpdatedDate = DateTime.Now;
                                context.Entry(aprl).State = EntityState.Modified;
                                await context.SaveChangesAsync();
                                result = 1;
                            }

                        }
                        else
                        {
                            HmsAppUserRole aprl = new HmsAppUserRole
                            {
                                RoleId = model.Role_Id,
                                AppUserId = model.AppUserID,
                                IsActive = 1,
                                CreatedBy = model.AppUserID,
                                CreatedDate = DateTime.Now,
                            };
                            context.HmsAppUserRoles.Add(aprl);
                            context.Entry(aprl).State = EntityState.Added;
                            await context.SaveChangesAsync();
                            result = 1;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            if (result != 0)
            {
                IsAdded = true;
            }
            return await Task.Run(() => IsAdded);
        }

        public async Task<bool> DeleteAppUserRole(int AppUsrRoleId)
        {
            bool IsDeleted = false;
            int result = 0;
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    HmsAppUserRole? aprl = context.HmsAppUserRoles.AsNoTracking().Where(a => a.IsActive == 1 && a.AppUserRoleId == AppUsrRoleId).FirstOrDefault();
                    if (aprl != null)
                    {
                        aprl.IsActive = 0;
                        aprl.UpdatedDate = DateTime.Now;
                        context.Entry(aprl).State = EntityState.Modified;
                        await context.SaveChangesAsync();
                        result = 1;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            if (result != 0)
            {
                IsDeleted = true;
            }
            return await Task.Run(() => IsDeleted);
        }

        public async Task<List<UserRoleMenuModel>> GetAllMenuAccessListOnRoleId(int Role_Id)
        {
            List<UserRoleMenuModel> usermenus = null;
            List<UserRoleMenuModel> usrmenustatus = null;
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    usermenus = await (from mainmenu in context.HmsMainMenus.AsNoTracking()
                                       join menuctrl in context.HmsMainMenuControls.AsNoTracking() on mainmenu.MainMenuId equals menuctrl.MainMenuId into menuctrlset
                                       from defmnuctrlset in menuctrlset.DefaultIfEmpty()
                                       select new UserRoleMenuModel
                                       {
                                           Main_Menu_Id = mainmenu.MainMenuId,
                                           MenuName = mainmenu.MenuName,
                                           MenuObjectName = mainmenu.MenuObjectName,
                                           Parent_Id = mainmenu.ParentId,
                                           ActionName = defmnuctrlset.ActionName,
                                           ControllerName = defmnuctrlset.ControllerName,
                                           MenuLogoPath = defmnuctrlset.MenuLogoPath,
                                       }).ToListAsync();

                    usrmenustatus = await (from rolmenu in context.HmsRolesMenus.AsNoTracking().Where(a => a.RoleId == Role_Id && a.MainMenuTabsId == null)
                                           select new UserRoleMenuModel
                                           {
                                               Main_Menu_Id = rolmenu.MenuId,
                                               Role_Id = rolmenu.RoleId,
                                               AccessStatus = Convert.ToBoolean(rolmenu.AccessStatus)
                                           }).ToListAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }

            if (usermenus != null && usermenus.Count > 0 && usrmenustatus != null && usrmenustatus.Count > 0)
            {
                foreach (var item in usrmenustatus)
                {
                    foreach (var item2 in usermenus)
                    {
                        if (item.Main_Menu_Id == item2.Main_Menu_Id)
                        {
                            item2.AccessStatus = item.AccessStatus;
                        }
                    }
                }
            }
            return usermenus.Where(a => a.AccessStatus == true).ToList();
        }

        public async Task<List<UserRoleMenuModel>> GetAllMenusBasedOnRoleId(int Role_Id)
        {
            List<UserRoleMenuModel> usermenus = null;
            List<UserRoleMenuModel> usrmenustatus = null;
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    usermenus = await (from mainmenu in context.HmsMainMenus.AsNoTracking()
                                       join menuctrl in context.HmsMainMenuControls.AsNoTracking() on mainmenu.MainMenuId equals menuctrl.MainMenuId into menuctrlset
                                       from defmnuctrlset in menuctrlset.DefaultIfEmpty()
                                       select new UserRoleMenuModel
                                       {
                                           Main_Menu_Id = mainmenu.MainMenuId,
                                           MenuName = mainmenu.MenuName,
                                           MenuObjectName = mainmenu.MenuObjectName,
                                           Parent_Id = mainmenu.ParentId,
                                           ActionName = defmnuctrlset.ActionName,
                                           ControllerName = defmnuctrlset.ControllerName,
                                           MenuLogoPath = defmnuctrlset.MenuLogoPath,
                                       }).ToListAsync();

                    usrmenustatus = await (from rolmenu in context.HmsRolesMenus.AsNoTracking().Where(a => a.RoleId == Role_Id && a.MainMenuTabsId == null)
                                           select new UserRoleMenuModel
                                           {
                                               Main_Menu_Id = rolmenu.MenuId,
                                               Role_Id = rolmenu.RoleId,
                                               AccessStatus = Convert.ToBoolean(rolmenu.AccessStatus)
                                           }).ToListAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }

            if (usermenus != null && usermenus.Count > 0 && usrmenustatus != null && usrmenustatus.Count > 0)
            {
                foreach (var item in usrmenustatus)
                {
                    foreach (var item2 in usermenus)
                    {
                        if (item.Main_Menu_Id == item2.Main_Menu_Id)
                        {
                            item2.AccessStatus = item.AccessStatus;
                            item2.Role_Id = item.Role_Id;
                        }
                    }
                }
            }
            List<UserRoleMenuModel> Allmenus = GetMenuTree(usermenus, null);
            return Allmenus;
        }

        private List<UserRoleMenuModel> GetMenuTree(List<UserRoleMenuModel> menu, int? parentId)
        {
            return menu.Where(x => x.Parent_Id == parentId).Select(x => new UserRoleMenuModel()
            {
                Main_Menu_Id = x.Main_Menu_Id,
                MenuName = x.MenuName,
                MenuObjectName = x.MenuObjectName,
                Role_Id = x.Role_Id,
                AccessStatus = (bool)x.AccessStatus,
                Parent_Id = x.Parent_Id,
                ActionName = x.ActionName,
                ControllerName = x.ControllerName,
                MenuLogoPath = x.MenuLogoPath,
                Submenu = GetMenuTree(menu, x.Main_Menu_Id),
            }).ToList();
        }



        public async Task<bool> SaveRoleAccessMenus(List<UserRoleMenuModel> menus)
        {
            bool IsAdded = false;
            int result = 0;
            try
            {
                using (var context = new HMS_Api_DbContext())
                {
                    if (menus != null && menus.Count > 0)
                    {
                        List<HmsRolesMenu>? rlmnu = context.HmsRolesMenus.Where(a => a.RoleId == menus[0].Role_Id).ToList();
                        if (rlmnu != null)
                        {
                            context.HmsRolesMenus.RemoveRange(rlmnu);
                            await context.SaveChangesAsync();
                        }
                        foreach (var item in menus)
                        {
                            HmsRolesMenu rm = new HmsRolesMenu
                            {
                                RoleId = item.Role_Id,
                                MenuId = item.Main_Menu_Id,
                                AccessStatus = 1
                            };
                            context.HmsRolesMenus.Add(rm);
                            await context.SaveChangesAsync();
                        }


                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }

            if (result != 0)
            {
                IsAdded = true;
            }
            return await Task.Run(() => IsAdded);
        }


        ~User()
        {
            Dispose(false);
        }

        private bool IsDisposed = false;

        public virtual void Dispose(bool Disposing)
        {
            if (IsDisposed)
                return;

            if (Disposing)
            {
                //free managed objects... IN this case it doesnt exist..
            }

            //if (context != null)
            //    context.Dispose();

            IsDisposed = true;

        }
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        
    }
}
