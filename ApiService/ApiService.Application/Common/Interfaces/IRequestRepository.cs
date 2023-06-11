using ApiService.Application.Domain.Entities;

namespace ApiService.Application.Common.Interfaces;

public interface IRequestRepository
{
    Task<IReadOnlyList<Request>> GetAllRequests();
    Task<IReadOnlyList<Request>> OpenRequests();
    Task<Request?> GetRequestById(Guid requestId);
    Task CreateRequest(Request request);
}
