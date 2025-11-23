using AppRedSocial.Repositories;
using AuthenticationApp.DTOS;
using AutoMapper;

namespace AppRedSocial.Services
{
    public class AuthService(IUserRepository userRepo, ITokenService tokenService, IEmailService emailService, IMapper mapper) : IAuthService
    {
        public Task<bool> ChangePasswordAsync(string username, ChangePasswordDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ConfirmEmailAsync(string email, string token)
        {
            throw new NotImplementedException();
        }

        public Task<(bool Success, LoginResponseDto? Result, string? ErrorMessage)> LoginAsync(LoginRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponseDto?> RefreshAccessTokenAsync(string refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task<(bool Success, string? ErrorMessage)> RegisterAsync(RegisterRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResendConfirmationEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResetPasswordAsync(ResetPasswordRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendResetPasswordLinkAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
