using Google.Protobuf.WellKnownTypes;

namespace TransformerAPI.Shared.Filters
{
    public class BaseFilter
    {
        public Timestamp Created_At { get; set; }
        public Timestamp Update_At { get; set; }
    }
}
