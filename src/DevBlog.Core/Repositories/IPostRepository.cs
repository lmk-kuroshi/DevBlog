using DevBlog.Core.Domain.Content;
using DevBlog.Core.SeedWorks;

namespace DevBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post,Guid>
    {
        Task<List<Post>> GetPopularPostAsync(int count);

    }
}
