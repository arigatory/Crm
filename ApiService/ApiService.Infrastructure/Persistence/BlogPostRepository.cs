using ApiService.Application.Common.Interfaces;
using ApiService.Application.Domain.Entities;

namespace ApiService.Infrastructure.Persistence;

public class BlogPostRepository : IBlogPostRepository
{
    private readonly CrmDbContext _context;

    public BlogPostRepository(CrmDbContext context)
    {
        _context = context;
    }
    public IReadOnlyList<BlogPost> AllBlogPosts
    {
        get
        {
            return _context.BlogPosts.ToList();
        }
    }

    public BlogPost? GetById(Guid id)
    {
        return _context.BlogPosts.FirstOrDefault(x => x.Id == id);
    }
}