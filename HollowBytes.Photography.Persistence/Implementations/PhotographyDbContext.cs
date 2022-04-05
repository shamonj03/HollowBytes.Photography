using HollowBytes.Photography.Persistence.Abstract;
using HollowBytes.Photography.Persistence.Configuration;
using Microsoft.Extensions.Options;

namespace HollowBytes.Photography.Persistence.Implementations
{
    public class PhotographyDbContext : MongoDbContext<PhotographyDbConfiguration>
    {
        public PhotographyDbContext(IOptions<PhotographyDbConfiguration> options) : base(options)
        {
        }
    }
}
