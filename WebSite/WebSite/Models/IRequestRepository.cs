namespace WebSite.Models;

public interface IRequestRepository
{
    IReadOnlyList<Request> AllRequests { get; }
    IReadOnlyList<Request> OpenRequests { get; }
    Request? GetRequestById(Guid requestId);
    void CreateRequest(Request request);
}
