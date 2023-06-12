using ApiService.Application.Features.Requests.Commands.SendRequest;
using ApiService.Application.Features.Requests.Queries.GetAllRequests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiService.Api.Controllers;

[Route("api/images")]
[ApiController]
public class ImageController : ControllerBase
{
    private readonly IMediator _mediator;

    public ImageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(Name = "Получить изображение")]
    public async Task<ActionResult<IReadOnlyList<RequestVm>>> GetImage()
    {
        Byte[] b = await System.IO.File.ReadAllBytesAsync(@"C:\Users\ariga\Pictures\9fdad24eb5801ff15f40b0c4f200b294.jpg");
        // You can use your own method over here.         
        return File(b, "image/jpeg");
    }

    [HttpGet("me", Name = "Получить свое изображение")]
    public async Task<ActionResult<IReadOnlyList<RequestVm>>> GetMe()
    {
        Byte[] b = await System.IO.File.ReadAllBytesAsync(@"Images\ivan.jpg");
        // You can use your own method over here.         
        return File(b, "image/jpeg");
    }
}
