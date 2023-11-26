using Domain.Entities;

namespace Application.Interfaces.Service
{
    public interface IUserService
    {
        Task<List<WMS_USER_EDITOR>> GetAll();
    }
}
