using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers;

public class RequestController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
