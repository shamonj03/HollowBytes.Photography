using MongoDB.Driver.GridFS;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace HollowBytes.Photography.Persistence.Interfaces.Repositories
{
    public interface IImagesRepository
    {
        Task InsertImageAsync(string fileName, Stream stream, CancellationToken cancellationToken = default);

        Task<byte[]> GetImageAsync(string filename, CancellationToken cancellationToken = default);

        Task<IEnumerable<GridFSFileInfo>> GetFilesAsync(CancellationToken cancellationToken = default);
    }
}
