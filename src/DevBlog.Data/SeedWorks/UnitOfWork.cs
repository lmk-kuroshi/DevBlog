using DevBlog.Core.SeedWorks;

namespace DevBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DevBlogContext _context;

        public UnitOfWork(DevBlogContext context)
        {
            _context = context;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        } 
    }
}
