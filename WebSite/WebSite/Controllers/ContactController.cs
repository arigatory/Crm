using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
