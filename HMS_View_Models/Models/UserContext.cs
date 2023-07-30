using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_View_Models.Models
{
    public class UserContext
    {
        public int? AppUserId { get; set; }
        public string? UserId { get; set; }
        public string? AppUserName { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public int? Role_Id { get; set; }
        public string? RoleName { get; set; }
        public bool canUpdate { get; set; }
        public bool canDelete { get; set; }
        public bool canAdd { get; set; }
        public bool isAuthenticated { get; set; }
    }
}
