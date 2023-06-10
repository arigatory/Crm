using WebSite.Models;

namespace WebSite.ViewModels;

public class BlogPostListViewModel
{
    public IReadOnlyList<BlogPost> BlogPosts { get; }

    public BlogPostListViewModel(IEnumerable<BlogPost> blogPosts)
    {
        BlogPosts = blogPosts.ToList();
    }
}