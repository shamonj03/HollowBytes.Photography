using HollowBytes.Photography.Persistence.Interfaces.Repositories;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace HollowBytes.Photography.Persistence.Implementations.Repositories
{
    public class ImagesRepository : IImagesRepository
    {
        private readonly GridFSBucket _bucket;

        public ImagesRepository(PhotographyDbContext context)
        {
            _bucket = new GridFSBucket(context.Database, new GridFSBucketOptions
            {
                BucketName = "images",
                ChunkSizeBytes = 1048576, // 1MB
                WriteConcern = WriteConcern.WMajority,
                ReadPreference = ReadPreference.Secondary
            });
        }

        public Task InsertImageAsync(string filename, Stream stream, CancellationToken cancellationToken = default)
        {
            return _bucket.UploadFromStreamAsync(filename, stream, cancellationToken: cancellationToken);
        }

        public Task<byte[]> GetImageAsync(string filename, CancellationToken cancellationToken = default)
        {
            return _bucket.DownloadAsBytesByNameAsync(filename, cancellationToken: cancellationToken);
        }

        public async Task<IEnumerable<GridFSFileInfo>> GetFilesAsync(CancellationToken cancellationToken = default)
        {
            var filter = Builders<GridFSFileInfo>.Filter.Empty;
            using (var cursor = await _bucket.FindAsync(filter, cancellationToken: cancellationToken))
            {
                return cursor.ToList();
            }
        }
    }
}
