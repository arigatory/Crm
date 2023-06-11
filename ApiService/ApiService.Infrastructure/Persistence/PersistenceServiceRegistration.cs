using ApiService.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiService.Infrastructure.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CrmDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("CrmDbContextConnection")));

        services.AddScoped<IRequestRepository, RequestRepository>();
        services.AddScoped<IBlogPostRepository, BlogPostRepository>();

        return services;
    }
}
