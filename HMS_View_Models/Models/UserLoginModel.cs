﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HMS_View_Models.Models
{
    public class UserLoginModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
