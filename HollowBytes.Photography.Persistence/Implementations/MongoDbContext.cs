using HollowBytes.Photography.Persistence.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace HollowBytes.Photography.Persistence.Implementations
{
    public class MongoDbContext : IMongoDbContext
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<IMongoDbConfiguration> options)
        {
            _client = new MongoClient(options.Value.ConnectionString);
            _database = _client.GetDatabase(options.Value.DatabaseName);
        }

        public GridFSBucket ImagesBucket => new GridFSBucket(_database, new GridFSBucketOptions
        {
            BucketName = "images",
            ChunkSizeBytes = 1048576, // 1MB
            WriteConcern = WriteConcern.WMajority,
            ReadPreference = ReadPreference.Secondary
        });
    }
}
