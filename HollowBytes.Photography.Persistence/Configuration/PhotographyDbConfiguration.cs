using HollowBytes.Photography.Persistence.Interfaces;

namespace HollowBytes.Photography.Persistence.Configuration
{
    public class PhotographyDbConfiguration : IMongoDbConfiguration
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
