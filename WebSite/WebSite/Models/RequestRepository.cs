namespace WebSite.Models;

public class RequestRepository : IRequestRepository
{
    private readonly CrmDbContext _context;

    public RequestRepository(CrmDbContext context)
    {
        _context = context;
    }
    public IReadOnlyList<Request> AllRequests
    {
        get
        {
            return _context.Requests.ToList();
        }
    }

    public IReadOnlyList<Request> OpenRequests
    {
        get
        {
            return _context.Requests
                .Where(x => x.Status == Status.Open)
                .ToList();
        }
    }

    public Request? GetRequestById(Guid requestId)
    {
        return _context.Requests.FirstOrDefault(x => x.Id == requestId);
    }
}
