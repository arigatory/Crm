using ApiService.Application.Features.BlogPosts.Queries.GetAllBlogPosts;
using ApiService.Application.Features.Requests.Queries.GetAllRequests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiService.Api.Controllers;

[Route("api/blog-posts")]
[ApiController]
public class BlogPostsController : ControllerBase
{
    private readonly IMediator _mediator;

    public BlogPostsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(Name = "Получить все посты блога")]
    public async Task<ActionResult<IReadOnlyList<BlogPostVm>>> GetAllRequests()
    {
        return Ok(await _mediator.Send(new GetAllBlogPostsQuery()));
    }
}
