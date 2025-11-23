using AppRedSocial.Data;
using AppRedSocial.Models;

namespace AppRedSocial.Repositories
{
    public class UserRepository(AppDbContext _context) : IUserRepository
    {
        public Task<User> AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetUserByRefreshTokenAsync(string refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetUserByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public bool ValidatePassWord(User user, string passWord)
        {
            throw new NotImplementedException();
        }
    }
}
