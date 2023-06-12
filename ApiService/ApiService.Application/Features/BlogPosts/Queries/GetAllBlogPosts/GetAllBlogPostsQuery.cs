using MediatR;

namespace ApiService.Application.Features.BlogPosts.Queries.GetAllBlogPosts;

public class GetAllBlogPostsQuery : IRequest<IReadOnlyList<BlogPostVm>>
{

}
