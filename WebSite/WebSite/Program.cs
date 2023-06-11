using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

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


app.Run();
