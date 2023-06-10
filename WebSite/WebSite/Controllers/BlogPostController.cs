using Microsoft.AspNetCore.Mvc;
using WebSite.Models;
using WebSite.ViewModels;

namespace WebSite.Controllers;

public class BlogPostController : Controller
{
    private readonly IRequestRepository _requestRepository;
    private readonly IBlogPostRepository _blogPostRepository;

    public BlogPostController(IRequestRepository requestRepository, 
        IBlogPostRepository blogPostRepository)
    {
        _requestRepository = requestRepository;
        _blogPostRepository = blogPostRepository;
    }

    public IActionResult List()
    {
        var blogPostsVM = new BlogPostListViewModel(_blogPostRepository.AllBlogPosts);
        return View(blogPostsVM);
    }
}
