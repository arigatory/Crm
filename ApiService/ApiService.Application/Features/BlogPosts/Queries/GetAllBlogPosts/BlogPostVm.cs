namespace ApiService.Application.Features.BlogPosts.Queries.GetAllBlogPosts;

public class BlogPostVm
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public string? Content { get; set; }
}