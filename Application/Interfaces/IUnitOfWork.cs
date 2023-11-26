using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthenticateRepositoryAsync authenticateRepositoryAsync { get; }
        IGenericRepositoryAsync<WMS_USER_EDITOR> userRepositoryAsync { get; }
        Task SaveChangesAsync();
    }
}
