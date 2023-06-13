using ApiService.Infrastructure.Identity;
using ApiService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ApiService.Api;

public static class StartupExtensions
{
    public static async Task ResetDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        try
        {
            var context = scope.ServiceProvider.GetService<CrmDbContext>();
            if (context != null)
            {
                await context.Database.EnsureDeletedAsync();
                await context.Database.MigrateAsync();
                await DbInitializer.SeedAsync(app);
            }
        }
        catch
        {
        }
        try
        {
            var context = scope.ServiceProvider.GetService<CrmIdentityDbContext>();
            if (context != null)
            {
                await context.Database.EnsureDeletedAsync();
                await context.Database.MigrateAsync();
            }
        }
        catch
        {
        }
    }
}