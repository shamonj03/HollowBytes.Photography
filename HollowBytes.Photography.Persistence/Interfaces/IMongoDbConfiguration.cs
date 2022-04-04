namespace HollowBytes.Photography.Persistence.Interfaces
{
    public interface IMongoDbConfiguration
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
