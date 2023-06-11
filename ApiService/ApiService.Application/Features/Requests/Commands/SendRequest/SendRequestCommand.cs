using MediatR;

namespace ApiService.Application.Features.Requests.Commands.SendRequest;

public class SendRequestCommand : IRequest
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}
