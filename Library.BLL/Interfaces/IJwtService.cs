using Library.DAL.Models.Auth;
using Microsoft.AspNetCore.Identity;


namespace Library.BLL.Interfaces
{
    public interface IJwtService
    {
        AuthenticationResponse CreateToken(IdentityUser user);
    }
}
