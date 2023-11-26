using Application.DTOs.Authenticate;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IAuthenticateRepositoryAsync : IGenericRepositoryAsync<WmsUserEditor>
    {
        Task<WmsUserEditor> SignInAsync(SignIn model);
        Task<bool> IsExistAsync(SignIn model);
    }
}
