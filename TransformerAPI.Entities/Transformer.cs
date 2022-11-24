using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TransformerAPI.Entities
{
    public class Transformer : Base
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public double Internal_Number { get; set; }
        public string Tension_Class { get; set; }
        public double Potency { get; set; }
        public int Current { get; set; }
    }
}
