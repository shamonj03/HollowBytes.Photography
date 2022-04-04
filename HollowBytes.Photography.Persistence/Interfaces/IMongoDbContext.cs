using MongoDB.Driver.GridFS;

namespace HollowBytes.Photography.Persistence.Interfaces
{
    public interface IMongoDbContext
    {
        GridFSBucket ImagesBucket { get; }
    }
}
