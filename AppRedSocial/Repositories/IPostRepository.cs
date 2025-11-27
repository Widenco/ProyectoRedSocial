using AppRedSocial.Models;

namespace AppRedSocial.Repositories
{
    public interface IPostRepository
    {
        Task AddPostAsync(Post post);
        Task UpdatePostAsync(Post post);
        Task DeletePostAsync(Post post);    
        Task<Post?> GetPostByIdAsync(int id);
        Task<IEnumerable<Post>> GetPostByUserAsync(int userId);
        Task<IEnumerable<Post>> GetAllAsync();
    }
}
