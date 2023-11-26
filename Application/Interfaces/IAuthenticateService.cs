using Application.DTOs.Authenticate;

namespace Application.Interfaces
{
    public interface IAuthenticateService
    {
        Task<SingInToken> SignIn(SignIn model);
        Task<bool> IsExistAsync(SignIn model);
    }
}
