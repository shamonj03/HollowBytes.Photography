using HollowBytes.Photography.Application.Models;
using MediatR;
using System.Collections.Generic;

namespace HollowBytes.Photography.Application.Requests
{
    public class GetAllImageInfoRequest : IRequest<IEnumerable<ImageInfoDto>>
    {
    }
}
