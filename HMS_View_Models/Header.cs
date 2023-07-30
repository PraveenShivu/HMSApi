using HMS_View_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_View_Models
{
    public class Header
    {
        public UserContext? userContext { get; set; }    
        public List<UserRoleMenuModel>? menulist { get; set; }
    }
}
