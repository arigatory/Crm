using ApiService.Application.Common.Interfaces;
using ApiService.Application.Domain.Entities;
using MediatR;

namespace ApiService.Application.Features.Requests.Queries.GetAllRequests;

public class GetAllRequestsQuery : IRequest<IReadOnlyList<RequestVm>>
{
}

public class GetAllRequestsQueryHandler : IRequestHandler<GetAllRequestsQuery, IReadOnlyList<RequestVm>>
{
    private readonly IRequestRepository _requestRepository;

    public GetAllRequestsQueryHandler(IRequestRepository requestRepository)
    {
        _requestRepository = requestRepository;
    }
    public async Task<IReadOnlyList<RequestVm>> Handle(GetAllRequestsQuery request, CancellationToken cancellationToken)
    {
        IReadOnlyList<Request> allRequests = await _requestRepository.GetAllRequests();
        return allRequests.Select(x => new RequestVm
        {
            Content = x.Content,
            Created = x.CreatedDate,
            Email = x.Email,
            Id = x.Id,
            Name = x.Name,
            Status = x.Status.ToString()
        }).ToList();
    }
}