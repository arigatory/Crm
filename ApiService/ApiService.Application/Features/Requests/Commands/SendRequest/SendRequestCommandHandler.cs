using ApiService.Application.Common.Interfaces;
using ApiService.Application.Domain.Entities;
using ApiService.Application.Features.Decorators;
using MediatR;

namespace ApiService.Application.Features.Requests.Commands.SendRequest;

[Log]
[Ivan]
public class SendRequestCommandHandler : IRequestHandler<SendRequestCommand>
{
    private readonly IRequestRepository _requestRepository;

    public SendRequestCommandHandler(IRequestRepository requestRepository)
    {
        _requestRepository = requestRepository;
    }

    public async Task Handle(SendRequestCommand request, CancellationToken cancellationToken)
    {
        Request newRequest = new()
        {
            Name = request.Name,
            Email = request.Email,
            Content = request.Content,
        };

        await _requestRepository.CreateRequest(newRequest);
    }
}