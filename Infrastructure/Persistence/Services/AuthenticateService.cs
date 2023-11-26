using AutoMapper;
using Application.DTOs.Authenticate;
using Application.Exceptions;
using Application.Extensions;
using Application.Interfaces;
using Application.Validators;
using Domain.Settings;
using System.Net;

namespace Infrastructure.Persistence.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly JWTSettings _jwtSetting;
        public AuthenticateService(IMapper mapper, IUnitOfWork unitOfWork, JWTSettings jwtSetting)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _jwtSetting = jwtSetting;
        }

        public async Task<bool> IsExistAsync(SignIn model)
        {
            return await _unitOfWork.authenticateRepositoryAsync.IsExistAsync(model);
        }

        public async Task<SingInToken> SignIn(SignIn model)
        {
            SignInCommandValidator validationRules = new SignInCommandValidator(_unitOfWork.authenticateRepositoryAsync);
            var password = model.Password.EncryptPass();
            //model.Password = password;
            model.Password = "PTixAGq+NebRksurqJZs9A==";
            var result = await validationRules.ValidateAsync(model);
            if (result.Errors.Any())
            {
                var Errors = result.Errors.Select(x => x.ErrorMessage).ToList();
                throw new ValidationException(Errors, (int)HttpStatusCode.BadRequest);
            }

            var user = await _unitOfWork.authenticateRepositoryAsync.SignInAsync(model);
            return await new Token(user.USERID.ToString(), user.USERNAME, "AdminWMS").GenerateTokenAsync(_jwtSetting);

        }
    }
}
