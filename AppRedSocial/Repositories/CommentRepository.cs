using AppRedSocial.Data;
using AppRedSocial.Models;

namespace AppRedSocial.Repositories
{
    public class CommentRepository(AppDbContext _context) : ICommentRepository
    {
        public Task<Comment> AddCommentAsycn(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCommentAsycn(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetCommentByUserAsycn(User user)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateCommentAsycn(Comment comment, User user)
        {
            throw new NotImplementedException();
        }
    }
}
