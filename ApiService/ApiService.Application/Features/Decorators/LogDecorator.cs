using MediatR;
using Newtonsoft.Json;

namespace ApiService.Application.Features.Decorators;

public class LogDecorator<TRequest> : IRequestHandler<TRequest> where TRequest : IRequest
{
    private readonly IRequestHandler<TRequest> _handler;

    public LogDecorator(IRequestHandler<TRequest> handler)
    {
        _handler = handler;
    }
    public Task Handle(TRequest request, CancellationToken cancellationToken)
    {
        string commandJson = JsonConvert.SerializeObject(request);
        Console.WriteLine(commandJson);
        return _handler.Handle(request, cancellationToken);
    }
}
