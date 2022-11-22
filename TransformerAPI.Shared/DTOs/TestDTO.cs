using System;

namespace TransformerAPI.Shared.DTOs
{
    public class TestDTO : BaseDTO
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime Duration_in_Seconds { get; set; }
    }
}
