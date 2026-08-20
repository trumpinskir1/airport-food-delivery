namespace backend.Data;

public class MongoDbSettings
{
    public string ConnectionString { get; set; } = string.Empty;

    public string DatabaseName { get; set; } = string.Empty;

    public string RestaurantsCollectionName { get; set; } = string.Empty;
}