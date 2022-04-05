using MongoDB.Driver;

namespace HollowBytes.Photography.Persistence.Interfaces
{
    public interface IMongoDbContext
    {
        IMongoDatabase Database { get; }
    }
}
