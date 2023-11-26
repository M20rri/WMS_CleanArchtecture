using Microsoft.EntityFrameworkCore;
using Application.DTOs.Authenticate;
using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;

namespace Infrastructure.Persistence.Repositories
{
    internal class AuthenticateRepositoryAsync : GenericRepositoryAsync<WMS_USER_EDITOR>, IAuthenticateRepositoryAsync
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<WMS_USER_EDITOR> _wmsUser;
        public AuthenticateRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _wmsUser = dbContext.Set<WMS_USER_EDITOR>();
        }

        public async Task<bool> IsExistAsync(SignIn model)
        {
            return await _wmsUser
              .AnyAsync(p => p.USERID == model.UserId && p.USERPASSWORD == model.Password);
        }

        public async Task<WMS_USER_EDITOR> SignInAsync(SignIn model)
        {
            return await _wmsUser
              .FirstOrDefaultAsync(p => p.USERID == model.UserId && p.USERPASSWORD == model.Password);
        }
    }
}
