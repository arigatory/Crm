using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Components;

public class LogedInUser : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View(new User { Name = "Ivan" });
    }
}
