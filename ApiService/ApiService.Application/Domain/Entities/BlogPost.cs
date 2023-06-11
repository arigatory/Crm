using ApiService.Application.Domain.Common;

namespace ApiService.Application.Domain.Entities;

public class BlogPost : AuditableEntity
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public string? Content { get; set; }
}
