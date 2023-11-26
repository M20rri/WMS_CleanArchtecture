using Application.DTOs.Authenticate;

namespace Application.Interfaces.Service
{
    public interface IAuthenticateService
    {
        Task<SingInToken> SignIn(SignIn model);
        Task<bool> IsExistAsync(SignIn model);
    }
}
