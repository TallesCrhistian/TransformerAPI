using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TransformerAPI.Entities
{
    public class User : Base
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
