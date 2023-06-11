namespace WebSite.Models;

public class BlogPost
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public string? Content { get; set; }
    public DateTime Created { get; set; }
}
