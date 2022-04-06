using HollowBytes.Photography.Application.Images.Models;
using MediatR;
using System.Collections.Generic;

namespace HollowBytes.Photography.Application.Images.Requests
{
    public class GetAllImageInfoRequest : IRequest<IEnumerable<ImageInfoDto>>
    {
    }
}
