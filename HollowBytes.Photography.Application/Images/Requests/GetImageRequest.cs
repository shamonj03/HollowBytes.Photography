using MediatR;

namespace HollowBytes.Photography.Application.Images.Requests
{
    public class GetImageRequest : IRequest<byte[]>
    {
        public string Filename { get; set; }
    }
}
