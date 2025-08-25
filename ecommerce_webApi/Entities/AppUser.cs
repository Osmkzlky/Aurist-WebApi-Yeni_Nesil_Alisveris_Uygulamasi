using Microsoft.AspNetCore.Identity;

namespace ecommerce_app.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
    }
}



