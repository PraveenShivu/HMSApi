using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_View_Models.Models;

namespace HMS_View_Models.ViewModels
{
    public class UserViewModel
    {
        public List<UserModel> UsersList { get; set; }
        public UserModel usermodel { get; set; }
        public string Message { get; set; }
        public List<UserRoleModel> UserRoleList { get; set; }
        public UserRoleModel userrolemodal { get; set; }
        public AppUserRoleModel appUserRolemodel { get; set; }
        public List<AppUserRoleModel> ListappUserRolemodel { get; set; }
        public List<UserRoleMenuModel> AllMenusOnRoleId { get; set; }



    }
}
