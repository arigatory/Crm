namespace ApiService.Application.Features.Requests.Queries.GetAllRequests;

public class RequestVm
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public DateTime Created { get; set; }
}
