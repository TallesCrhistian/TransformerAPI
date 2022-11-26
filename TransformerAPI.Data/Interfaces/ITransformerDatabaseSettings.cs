namespace TransformerAPI.Data.Interfaces
{
    public interface ITransformerDatabaseSettings
    {
        public string TransformerCollectionName { get; set; }
        public string ReportCollectionName { get; set; }
        public string TestCollectionName { get; set; }
        public string UserCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
