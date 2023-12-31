﻿using Application.Interfaces;
using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;

namespace Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IAuthenticateRepositoryAsync authenticateRepositoryAsync => new AuthenticateRepositoryAsync(_dbContext);
        public IGenericRepositoryAsync<WMS_USER_EDITOR> userRepositoryAsync => new GenericRepositoryAsync<WMS_USER_EDITOR>(_dbContext);

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
