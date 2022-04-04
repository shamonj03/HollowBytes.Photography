using HollowBytes.Photography.Persistence.Interfaces;

namespace HollowBytes.Photography.Persistence.Implementations
{
    public class MongoDbConfiguration : IMongoDbConfiguration
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
