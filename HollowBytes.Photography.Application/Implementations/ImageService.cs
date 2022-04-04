using HollowBytes.Photography.Application.Interfaces;
using HollowBytes.Photography.Application.Messages;
using HollowBytes.Photography.Persistence.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HollowBytes.Photography.Application.Implementations
{
    public class ImageService : IImageService,
        IRequestHandler<UploadImageRequest>
    {
        private readonly IMongoDbContext _mongoDbContext;

        public ImageService(IMongoDbContext mongoDbContext)
        {
            _mongoDbContext = mongoDbContext;
        }

        public async Task<Unit> Handle(UploadImageRequest request, CancellationToken cancellationToken)
        {
            var uploadTasks = request.Files
                .Select(file => _mongoDbContext.ImagesBucket.UploadFromStreamAsync(
                    file.FileName, file.OpenReadStream(), cancellationToken: cancellationToken));

            await Task.WhenAll(uploadTasks);
            return Unit.Value;
        }
    }
}
