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

    [HttpGet("{name}", Name = "Получить изображение по имени")]
    public async Task<ActionResult<IReadOnlyList<RequestVm>>> GetMe(string name)
    {
        Byte[] b;

        try
        {
            b = await System.IO.File.ReadAllBytesAsync($"Images\\{name}");
        }
        catch
        {
            return NotFound();
        }
        // You can use your own method over here.
        return File(b, "image/jpeg");
    }
}
