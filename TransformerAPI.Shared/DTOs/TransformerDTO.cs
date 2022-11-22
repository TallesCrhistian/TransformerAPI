namespace TransformerAPI.Shared.DTOs
{
    public class TransformerDTO : BaseDTO
    {
        public string Name { get; set; }
        public double Internal_Number { get; set; }
        public string Tension_Class { get; set; }
        public double Potency { get; set; }
        public int Current { get; set; }
    }
}
