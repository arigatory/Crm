using ApiService.Infrastructure.Identity.Model;
using Microsoft.AspNetCore.Identity;

namespace ApiService.Infrastructure.Identity.Seed;

public static class UserCreator
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
    {
        var applicationUser = new ApplicationUser
        {
            Name = "Ivan",
            UserName = "ivan",
            Email = "ivan@test.com",
            EmailConfirmed = true
        };

        var user = await userManager.FindByEmailAsync(applicationUser.Email);
        if (user == null)
        {
            await userManager.CreateAsync(applicationUser, "!QAZxsw2");
        }
    }
}