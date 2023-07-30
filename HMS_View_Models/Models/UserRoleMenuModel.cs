using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_View_Models.Models
{
    public class UserRoleMenuModel
    {
        public int Main_Menu_Id { get; set; }
        public string? MenuName { get; set; }
        public string? MenuObjectName { get; set; }
        public int Role_Id { get; set; }
        public int? Parent_Id { get; set; }
        public bool AccessStatus { get; set; }
        public string? ActionName { get; set; }
        public string? ControllerName { get; set; }
        public string? MenuLogoPath { get; set; }
        public List<UserRoleMenuModel>? Submenu { get; set; }
    }
}
