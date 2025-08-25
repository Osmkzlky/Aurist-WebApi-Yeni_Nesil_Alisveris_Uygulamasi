using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.DTOs.Account
{
    public class AdminChangePasswordDto
    {
        public string UserId { get; set; }
        public string NewPassword { get; set; }
    }
}