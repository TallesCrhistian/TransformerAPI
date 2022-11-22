using Google.Protobuf.WellKnownTypes;

namespace TransformerAPI.Shared.ViewModel
{
    public class BaseViewModel
    {
        public Timestamp Created_At { get; set; }
        public Timestamp Update_At { get; set; }
    }
}
