using Application.Interfaces;
using Application.Interfaces.Service;
using AutoMapper;
using Domain.Entities;
using Domain.Settings;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly JWTSettings _jwtSetting;

        public UserService(IMapper mapper, IUnitOfWork unitOfWork, JWTSettings jwtSetting)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _jwtSetting = jwtSetting;
        }

        public async Task<List<WMS_USER_EDITOR>> GetAll()
        {
            var users = await _unitOfWork.userRepositoryAsync.GetAllAsync();
            return await users.ToListAsync();
        }
    }
}
