using backend.Data;
using backend.Models;
using MongoDB.Driver;

namespace backend.Services;

public class RestaurantService
{
    private readonly MongoDbContext _context;

    public RestaurantService(MongoDbContext context)
    {
        _context = context;
    }

    public async Task<List<Restaurant>> GetAsync()
    {
        return await _context.Restaurants
            .Find(_ => true)
            .ToListAsync();
    }

    public async Task<Restaurant?> GetAsync(string id)
    {
        return await _context.Restaurants
            .Find(x => x.Id == id)
            .FirstOrDefaultAsync();
    }

    public async Task CreateAsync(Restaurant restaurant)
    {
        await _context.Restaurants.InsertOneAsync(restaurant);
    }
}