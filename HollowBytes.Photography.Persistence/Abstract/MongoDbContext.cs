using HollowBytes.Photography.Persistence.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace HollowBytes.Photography.Persistence.Abstract
{
    public abstract class MongoDbContext<T> : IMongoDbContext
        where T : class, IMongoDbConfiguration
    {
        public IMongoDatabase Database { get; private set; }

        public MongoDbContext(IOptions<T> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            Database = client.GetDatabase(options.Value.DatabaseName);
        }
    }
}
