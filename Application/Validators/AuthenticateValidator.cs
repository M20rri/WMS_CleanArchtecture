using FluentValidation;
using Application.DTOs.Authenticate;
using Application.Interfaces.Repositories;

namespace Application.Validators
{
    public class SignInCommandValidator : AbstractValidator<SignIn>
    {
        private readonly IAuthenticateRepositoryAsync _auth;
        public SignInCommandValidator(IAuthenticateRepositoryAsync auth)
        {
            _auth = auth;

            RuleFor(x => x.UserId).NotNull().NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Password is required");

            When(x => !string.IsNullOrEmpty(x.UserId.ToString()) && !string.IsNullOrEmpty(x.Password), () =>
            {
                RuleFor(o => o).MustAsync(IsValidCreds)
                .WithMessage("Invalid login Credentials");
            });
        }

        private async Task<bool> IsValidCreds(SignIn model, CancellationToken cancellationToken)
        {
            return await _auth.IsExistAsync(model);
        }
    }
}
