namespace WebSite.Models;

public interface IBlogPostRepository
{
    IReadOnlyList<BlogPost> AllBlogPosts { get; }
    BlogPost? GetById(Guid id);
}
