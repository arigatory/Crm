using Microsoft.AspNetCore.Mvc;
using WebSite.Models;
using WebSite.ViewModels;

namespace WebSite.Controllers;

public class HomeController : Controller
{
    private readonly IRequestRepository _requestRepository;

    public HomeController(IRequestRepository requestRepository)
    {
        _requestRepository = requestRepository;
    }
    public IActionResult Index()
    {
        HomeViewModel homeViewModel = new();
        return View(homeViewModel);
    }

    [HttpPost]
    public IActionResult Index(HomeViewModel homeViewModel)
    {
        if (string.IsNullOrEmpty(homeViewModel.Name))
        {
            ModelState.AddModelError("", "Введите, пожалуйста, имя");
        }

        if (string.IsNullOrEmpty(homeViewModel.Email))
        {
            ModelState.AddModelError("", "Введите, пожалуйста, email");
        }

        if (string.IsNullOrEmpty(homeViewModel.Content))
        {
            ModelState.AddModelError("", "Введите, пожалуйста, сообщение");
        }

        if (ModelState.IsValid)
        {
            Request request = new()
            {
                Content = homeViewModel.Content!,
                Created = DateTime.UtcNow,
                Email = homeViewModel.Email!,
                Name = homeViewModel.Name!,
                Status = Status.Open
            };
            _requestRepository.CreateRequest(request);
            return RedirectToAction("RequestCreated");
        }
        return View(homeViewModel);
    }

    public IActionResult RequestCreated()
    {
        ViewBag.Message = "Спасибо за интерес к нашей компании. Мы скоро с вами свяжемся";
        return View();
    }
}
