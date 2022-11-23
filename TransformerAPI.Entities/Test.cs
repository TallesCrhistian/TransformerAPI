using System;

namespace TransformerAPI.Entities
{
    public class Test : Base
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime Duration_in_Seconds { get; set; }
    }
}
