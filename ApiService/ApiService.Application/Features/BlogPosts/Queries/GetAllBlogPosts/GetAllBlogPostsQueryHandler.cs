using ApiService.Application.Common.Interfaces;
using MediatR;

namespace ApiService.Application.Features.BlogPosts.Queries.GetAllBlogPosts;

public class GetAllBlogPostsQueryHandler : IRequestHandler<GetAllBlogPostsQuery, IReadOnlyList<BlogPostVm>>
{
    private readonly IBlogPostRepository _blogPostRepository;

    public GetAllBlogPostsQueryHandler(IBlogPostRepository blogPostRepository)
    {
        _blogPostRepository = blogPostRepository;
    }

    public async Task<IReadOnlyList<BlogPostVm>> Handle(GetAllBlogPostsQuery request, CancellationToken cancellationToken)
    {
        var blogPosts = await _blogPostRepository.GetAllBlogPosts();
        return blogPosts.Select(x => new BlogPostVm
        {
            Id = x.Id,
            Title = x.Title,
            ImageUrl = x.ImageUrl,
            Content = x.Content
        }).ToList();
    }
}
