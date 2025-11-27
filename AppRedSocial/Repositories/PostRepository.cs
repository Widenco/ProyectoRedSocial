using AppRedSocial.Data;
using AppRedSocial.Models;
using Microsoft.EntityFrameworkCore;

namespace AppRedSocial.Repositories
{
    public class PostRepository(AppDbContext _context) : IPostRepository
    {
        public async Task AddPostAsync(Post post)
        {
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePostAsync(Post post)
        {
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            return await _context.Posts
            .Include(p => p.User)
            .Include(p => p.Comments)
            .ToListAsync();
        }

<<<<<<< Updated upstream
        public async Task<Post> GetPostByUserAsync(User user)
=======
        public async Task<Post?> GetPostByIdAsync(int id)
>>>>>>> Stashed changes
        {
            return await _context.Posts
            .Include(p => p.User)
            .Include(p => p.Comments)
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Post>> GetPostByUserAsync(int userId)
        {
            return await _context.Posts
            .Where(p => p.UserId == userId)
            .Include(p => p.Comments)
            .ToListAsync();
        }

        public async Task UpdatePostAsync(Post post)
        {
            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
        }
    }
}
