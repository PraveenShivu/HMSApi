using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_View_Models.Models
{
    public class UserRoleModel
    {
        public int Role_Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public int IsActive { get; set; }
    }
}
