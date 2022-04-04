using HollowBytes.Photography.Application.Messages;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;
using System.Threading.Tasks;

namespace HollowBytes.Photography.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ImagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [SwaggerResponse(typeof(void))]
        public async Task<IActionResult> Upload(UploadImageRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
