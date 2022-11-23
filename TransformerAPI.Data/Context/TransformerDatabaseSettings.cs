using TransformerAPI.Data.Interfaces;

namespace TransformerAPI.Data.Context
{
    public class TransformerDatabaseSettings : ITransformerDatabaseSettings
    {
        public string TransformerCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
