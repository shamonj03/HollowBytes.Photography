using MediatR;

namespace HollowBytes.Photography.Application.Requests
{
    public class GetImageRequest : IRequest<byte[]>
    {
        public string Filename { get; set; }
    }
}
