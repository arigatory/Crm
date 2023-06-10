namespace WebSite.Models;

public class Request
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public Status Status { get; set; } = Status.Open;
}
