using ApiService.Application.Domain.Common;

namespace ApiService.Application.Domain.Entities;

public class Request : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public Status Status { get; set; } = Status.Open;

    public DateTime Created { get; set; }
}
