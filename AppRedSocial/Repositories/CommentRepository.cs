using AppRedSocial.Data;
using AppRedSocial.Models;
using Microsoft.EntityFrameworkCore;

namespace AppRedSocial.Repositories
{
    public class CommentRepository(AppDbContext _context) : ICommentRepository
    {
<<<<<<< Updated upstream
        public async Task<Comment> AddCommentAsycn(Comment comment)
=======
        public async Task AddCommentAsycn(Comment comment)
>>>>>>> Stashed changes
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCommentAsycn(Comment comment)
        {
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
        }

<<<<<<< Updated upstream
        public async Task<Comment> GetCommentById(int id)
=======
        public async Task<Comment?> GetCommentById(int id)
>>>>>>> Stashed changes
        {
            return await _context.Comments
            .Include(c => c.User)
            .Include(c => c.Post)
            .FirstOrDefaultAsync(c => c.Id == id);
        }

<<<<<<< Updated upstream
        public async Task<Comment> GetCommentByUserAsycn(User user)
=======
        public async Task<IEnumerable<Comment>> GetCommentByPostAsycn(int postId)
>>>>>>> Stashed changes
        {
            return await _context.Comments
            .Where(c => c.PostId == postId)
            .Include(c => c.User)
            .ToListAsync();
        }
    }
}
