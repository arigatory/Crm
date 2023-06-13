using Microsoft.AspNetCore.Identity;

namespace ApiService.Infrastructure.Identity.Model;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; } = string.Empty;
}
