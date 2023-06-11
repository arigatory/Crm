using ApiService.Application.Domain.Common;

namespace ApiService.Application.Domain.Entities;

public class User : AuditableEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
}
