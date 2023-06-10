using Microsoft.EntityFrameworkCore;

namespace WebSite.Models;

public class CrmDbContext : DbContext
{
    public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options)
    {
    }

    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Request> Requests{ get; set; }
}
