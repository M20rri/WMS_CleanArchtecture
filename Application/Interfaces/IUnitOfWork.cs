using Application.Interfaces.Repositories;

namespace Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthenticateRepositoryAsync authenticateRepositoryAsync { get; }
        Task SaveChangesAsync();
    }
}
