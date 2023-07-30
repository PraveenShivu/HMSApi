using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_View_Models.Models
{
    public class AppUserRoleModel
    {
        public int AppUserRole_Id { get; set; }
        public int Role_Id { get; set; }
        public string? AppRoleName { get; set; }
        public int AppUserID { get; set; }
        public string? AppUserName { get; set; }
        public int IsActive { get; set; }
    }
}
