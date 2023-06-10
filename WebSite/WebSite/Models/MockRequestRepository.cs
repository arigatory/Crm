namespace WebSite.Models;

public class MockRequestRepository : IRequestRepository
{
    public IReadOnlyList<Request> AllRequests => new List<Request>{
        new Request
        {
             Id = Guid.NewGuid(),
             Content = "asdf",
             Email = "a@s.c",
             Name = "Test",
             Status = Status.Open
        },
        new Request
        {
             Id = Guid.NewGuid(),
             Content = "asdf",
             Email = "b@s.c",
             Name = "Test",
             Status = Status.Open
        },
        new Request
        {
             Id = Guid.NewGuid(),
             Content = "asdf",
             Email = "s@s.c",
             Name = "Test",
             Status = Status.InProgress
        },
        new Request
        {
             Id = Guid.NewGuid(),
             Content = "asdf",
             Email = "a@s.c",
             Name = "Test",
             Status = Status.Completed
        },
    };

    public IReadOnlyList<Request> OpenRequests => AllRequests
        .Where(x => x.Status == Status.Open)
        .ToList();


    public Request? GetRequestById(Guid requestId)
    {
        return AllRequests.FirstOrDefault(x => x.Id == requestId);
    }
}