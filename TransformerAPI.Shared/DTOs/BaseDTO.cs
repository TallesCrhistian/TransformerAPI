using Google.Protobuf.WellKnownTypes;

namespace TransformerAPI.Shared.DTOs
{
    public class BaseDTO
    {
        public Timestamp Created_At { get; set; }
        public Timestamp Update_At { get; set; }
    }
}
