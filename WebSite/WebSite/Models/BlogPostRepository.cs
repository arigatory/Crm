namespace WebSite.Models;

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