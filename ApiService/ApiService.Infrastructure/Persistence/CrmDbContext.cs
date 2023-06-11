using ApiService.Application.Domain.Common;
using ApiService.Application.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiService.Infrastructure.Persistence;

public class CrmDbContext : DbContext
{
    public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options)
    {
    }

    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Request> Requests { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    entry.Entity.CreatedBy = null;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    entry.Entity.LastModifiedBy = null;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
