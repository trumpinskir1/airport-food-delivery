using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models;

public class Restaurant
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string AirportCode { get; set; } = string.Empty;

    public string Terminal { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool IsOpen { get; set; }

    public List<MenuItem> Menu { get; set; } = [];
}

public class MenuItem
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }
}