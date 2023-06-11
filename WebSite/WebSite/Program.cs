using Microsoft.EntityFrameworkCore;
using WebSite.Models;
using Microsoft.AspNetCore.Identity;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CrmDbContextConnection") ?? throw new InvalidOperationException("Connection string 'CrmDbContextConnection' not found.");

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CrmDbContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:CrmDbContextConnection"]);
});

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<CrmDbContext>();

builder.Services.AddScoped<IBlogPostRepository, BlogPostRepository>();
builder.Services.AddScoped<IRequestRepository, RequestRepository>();

WebApplication app = builder.Build();

app.UseStaticFiles();

app.UseAuthentication();

app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapFallbackToController("Index", "Fallback");
app.MapDefaultControllerRoute();


DbInitializer.Seed(app);

app.Run();
