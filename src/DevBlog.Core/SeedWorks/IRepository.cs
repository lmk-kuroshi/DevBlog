using System.Linq.Expressions;

namespace DevBlog.Core.SeedWorks
{
    public interface IRepository<T, Key> where T : class
    {
        Task<T> GetByIdAsync(Key id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        public void Remove(T entity);
        public void RemoveRange(IEnumerable<T> entities);
    }
}
