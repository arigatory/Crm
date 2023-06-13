using ApiService.Infrastructure.Identity.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiService.Infrastructure.Identity;

public class CrmIdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public CrmIdentityDbContext()
    {
        
    }

    public CrmIdentityDbContext(DbContextOptions<CrmIdentityDbContext> options) : base(options)
    {
    }
}
