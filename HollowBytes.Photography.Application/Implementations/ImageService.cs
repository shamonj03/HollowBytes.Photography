﻿using HollowBytes.Photography.Application.Interfaces;
using HollowBytes.Photography.Application.Models;
using HollowBytes.Photography.Application.Requests;
using HollowBytes.Photography.Persistence.Interfaces.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HollowBytes.Photography.Application.Implementations
{
    public class ImageService : IImageService,
        IRequestHandler<UploadImageRequest>,
        IRequestHandler<GetImageRequest, byte[]>,
        IRequestHandler<GetAllImageInfoRequest, IEnumerable<ImageInfoDto>>
    {
        private readonly IImagesRepository _imagesRepository;

        public ImageService(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;
        }

        public async Task<Unit> Handle(UploadImageRequest request, CancellationToken cancellationToken)
        {
            var uploadTasks = request.Files
                .Select(file => _imagesRepository.InsertImageAsync(
                    file.FileName, file.OpenReadStream(), cancellationToken: cancellationToken));

            await Task.WhenAll(uploadTasks);
            return Unit.Value;
        }

        public Task<byte[]> Handle(GetImageRequest request, CancellationToken cancellationToken)
        {
            return _imagesRepository.GetImageAsync(request.Filename, cancellationToken);
        }

        public async Task<IEnumerable<ImageInfoDto>> Handle(GetAllImageInfoRequest request, CancellationToken cancellationToken)
        {
            var files = await _imagesRepository.GetFilesAsync(cancellationToken);

            return files.Select(x => new ImageInfoDto
            {
                Filename = x.Filename
            });
        }
    }
}
