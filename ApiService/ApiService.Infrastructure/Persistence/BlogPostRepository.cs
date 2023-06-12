using ApiService.Application.Common.Interfaces;
using ApiService.Application.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiService.Infrastructure.Persistence;

public class BlogPostRepository : IBlogPostRepository
{
    private readonly CrmDbContext _context;

    public BlogPostRepository(CrmDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<BlogPost>> GetAllBlogPosts()
    {
        return await _context.BlogPosts.ToListAsync();
    }

    public async Task<BlogPost?> GetById(Guid id)
    {
        return await _context.BlogPosts.FirstOrDefaultAsync(x => x.Id == id);
    }
}