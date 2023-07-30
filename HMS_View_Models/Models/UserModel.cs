using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_View_Models.Models
{
    public class UserModel
    {
        public int AppUserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserId { get; set; }
        public string? EmailId { get; set; }
        public string? Password { get; set; }
        public string? HashPassword { get; set; }
        public string? MobileNumber { get; set; }
        public bool IsActive { get; set; }

        public DateTime? RegisterDate { get; set; }
    }
}
