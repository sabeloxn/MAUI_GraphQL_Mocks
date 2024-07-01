using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SampSupps.Models;

public partial class BaseEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string id { get; set; }
}