using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IRequestRepository _requestRepository;

        public SearchController(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_requestRepository.AllRequests);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var request = _requestRepository.GetRequestById(id);
            if (request == null) return NotFound();

            return Ok();
        }
    }
}
