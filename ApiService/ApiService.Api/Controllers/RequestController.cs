using ApiService.Application.Features.Requests.Commands.SendRequest;
using ApiService.Application.Features.Requests.Queries.GetAllRequests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiService.Api.Controllers;

[Route("api/requests")]
[ApiController]
public class RequestController : ControllerBase
{
    private readonly IMediator _mediator;

    public RequestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(Name = "Получить все запросы")]
    public async Task<ActionResult<IReadOnlyList<RequestVm>>> GetAllRequests()
    {
        return Ok(await _mediator.Send(new GetAllRequestsQuery()));
    }

    [HttpPost(Name = "Отправить запрос")]
    public async Task<IActionResult> SendRequest(SendRequestCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }
}
