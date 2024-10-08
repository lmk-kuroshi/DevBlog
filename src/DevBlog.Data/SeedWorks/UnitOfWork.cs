﻿using AutoMapper;
using DevBlog.Core.Repositories;
using DevBlog.Core.SeedWorks;
using DevBlog.Data.Repositories;

namespace DevBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DevBlogContext _context;

        public UnitOfWork(DevBlogContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
        }
        public IPostRepository Posts { get; private set; }
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
