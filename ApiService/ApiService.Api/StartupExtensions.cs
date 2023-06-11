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
        catch (Exception ex)
        {
            var logger = scope.ServiceProvider.GetRequiredService<ILogger>();
            logger.LogError(ex, "An error occurred while migrating the database.");
        }
    }
}