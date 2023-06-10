using Microsoft.EntityFrameworkCore;
using WebSite.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CrmDbContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:CrmDbContextConnection"]);
});

builder.Services.AddScoped<IBlogPostRepository, BlogPostRepository>();
builder.Services.AddScoped<IRequestRepository, RequestRepository>();

WebApplication app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

DbInitializer.Seed(app);

app.Run();
