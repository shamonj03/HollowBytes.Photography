using HollowBytes.Photography.Application.Images.Models;
using HollowBytes.Photography.Application.Images.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Collections.Generic;
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
        [SwaggerResponse(typeof(void))]
        public async Task<IActionResult> Upload([FromForm] UploadImageRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpGet("{filename}")]
        [SwaggerResponse(typeof(byte[]))]
        public async Task<IActionResult> GetImage([FromRoute] GetImageRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpGet]
        [SwaggerResponse(typeof(IEnumerable<ImageInfoDto>))]
        public async Task<IActionResult> GetImages(GetAllImageInfoRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
