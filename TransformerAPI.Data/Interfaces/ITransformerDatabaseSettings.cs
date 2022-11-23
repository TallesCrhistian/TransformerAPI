namespace TransformerAPI.Data.Interfaces
{
    public interface ITransformerDatabaseSettings
    {
        string TransformerCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
