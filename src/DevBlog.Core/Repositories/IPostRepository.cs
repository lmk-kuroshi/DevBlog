﻿using DevBlog.Core.Domain.Content;
using DevBlog.Core.Models;
using DevBlog.Core.Models.Content;
using DevBlog.Core.SeedWorks;

namespace DevBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post,Guid>
    {
        Task<List<Post>> GetPopularPostAsync(int count);
        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string? keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10); 
    }
}
