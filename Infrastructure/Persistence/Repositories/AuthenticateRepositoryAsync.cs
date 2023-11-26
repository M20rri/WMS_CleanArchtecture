using Microsoft.EntityFrameworkCore;
using Application.DTOs.Authenticate;
using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Persistence.Contexts;

namespace Infrastructure.Persistence.Persistence.Repositories
{
    internal class AuthenticateRepositoryAsync : GenericRepositoryAsync<WmsUserEditor>, IAuthenticateRepositoryAsync
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<WmsUserEditor> _wmsUser;
        public AuthenticateRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _wmsUser = dbContext.Set<WmsUserEditor>();
        }

        public async Task<bool> IsExistAsync(SignIn model)
        {
            return await _wmsUser
              .AnyAsync(p => p.Userid == model.UserId && p.Userpassword == model.Password);
        }

        public async Task<WmsUserEditor> SignInAsync(SignIn model)
        {
            try
            {
                var user = await _wmsUser.FirstOrDefaultAsync(a => a.Srno == 927);

                return await _wmsUser
              .FirstOrDefaultAsync(p => p.Userid == model.UserId && p.Userpassword == model.Password);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
