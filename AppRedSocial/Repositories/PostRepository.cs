using AppRedSocial.Data;
using AppRedSocial.Models;

namespace AppRedSocial.Repositories
{
    public class PostRepository(AppDbContext _context) : IPostRepository
    {
        public Task<Post> AddPostAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePostAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostByUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePostAsync(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
