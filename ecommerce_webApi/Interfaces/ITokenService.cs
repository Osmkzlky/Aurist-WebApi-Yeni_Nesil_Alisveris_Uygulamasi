using ecommerce_app.Models;

namespace ecommerce_app.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}