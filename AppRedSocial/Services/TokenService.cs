using AppRedSocial.Models;
using AppRedSocial.Models.Settings;
using Microsoft.Extensions.Options;

namespace AppRedSocial.Services
{
    public class TokenService(IOptions<JwtSettings> options) : ITokenService
    {
        public string GenerateAccessToken(User user)
        {
            throw new NotImplementedException();
        }

        public string GeneratePasswordResetToken()
        {
            throw new NotImplementedException();
        }

        public string GenerateRefreshToken()
        {
            throw new NotImplementedException();
        }
    }
}
