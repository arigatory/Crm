using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

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
        ViewBag.CurrentBlogPosts = "All";
        return View(_blogPostRepository.AllBlogPosts);
    }
}
