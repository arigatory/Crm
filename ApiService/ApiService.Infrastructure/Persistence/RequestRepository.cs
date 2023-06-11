using ApiService.Application.Common.Interfaces;
using ApiService.Application.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiService.Infrastructure.Persistence;

public class RequestRepository : IRequestRepository
{
    private readonly CrmDbContext _context;

    public RequestRepository(CrmDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Request>> GetAllRequests()
    {
        return await _context.Requests.ToListAsync();
    }

    public async Task<IReadOnlyList<Request>> OpenRequests()
    {
        return await _context.Requests
            .Where(x => x.Status == Status.Open)
            .ToListAsync();
    }

    public async Task CreateRequest(Request request)
    {
        _context.Requests.Add(request);
        await _context.SaveChangesAsync();
    }

    public async Task<Request?> GetRequestById(Guid requestId)
    {
        return await _context.Requests
            .FirstOrDefaultAsync(x => x.Id == requestId);
    }
}
