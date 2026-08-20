using Microsoft.Extensions.Options;
using MongoDB.Driver;
using backend.Models;

namespace backend.Data;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(IOptions<MongoDbSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString);

        _database = client.GetDatabase(settings.Value.DatabaseName);
    }

    public IMongoCollection<Restaurant> Restaurants =>
        _database.GetCollection<Restaurant>("restaurants");
}