using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TransformerAPI.Entities
{
    public class Test : Base
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime Duration_in_Seconds { get; set; }
    }
}
