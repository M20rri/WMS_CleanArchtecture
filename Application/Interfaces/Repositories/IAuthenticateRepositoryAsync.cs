using Application.DTOs.Authenticate;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IAuthenticateRepositoryAsync : IGenericRepositoryAsync<WMS_USER_EDITOR>
    {
        Task<WMS_USER_EDITOR> SignInAsync(SignIn model);
        Task<bool> IsExistAsync(SignIn model);
    }
}
