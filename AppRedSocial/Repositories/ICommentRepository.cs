using AppRedSocial.Models;

namespace AppRedSocial.Repositories
{
    public interface ICommentRepository
    {
        Task AddCommentAsycn(Comment comment);
        Task DeleteCommentAsycn(Comment comment);  
        Task<IEnumerable<Comment>> GetCommentByPostAsycn(int postId);
        Task<Comment?> GetCommentById(int id);
    }
}
