using System;

namespace TransformerAPI.Entities
{
    public class Report : Base
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
