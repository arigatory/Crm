using MediatR;

namespace ApiService.Application.Features.Decorators
{
    public class IvanDecorator<TRequest> : IRequestHandler<TRequest> where TRequest : IRequest
    {
        private readonly IRequestHandler<TRequest> _handler;

        public IvanDecorator(IRequestHandler<TRequest> handler)
        {
            _handler = handler;
        }
        public Task Handle(TRequest request, CancellationToken cancellationToken)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ivan");
            }
            var res = _handler.Handle(request, cancellationToken);
            return res;
        }
    }
}
