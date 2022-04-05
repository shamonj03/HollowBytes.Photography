using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace HollowBytes.Photography.Application.Requests
{
    public class UploadImageRequest : IRequest
    {
        public IEnumerable<IFormFile> Files { get; set; }
    }
}
