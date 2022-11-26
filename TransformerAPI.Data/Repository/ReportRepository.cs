using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly IMongoCollection<Report> _mongoCollection;

        public ReportRepository(ITransformerDatabaseSettings transformerDatabaseSettings)
        {
            var client = new MongoClient(transformerDatabaseSettings.ConnectionString);
            var database = client.GetDatabase(transformerDatabaseSettings.DatabaseName);

            _mongoCollection = database.GetCollection<Report>(transformerDatabaseSettings.TransformerCollectionName);
        }
        public async Task<Report> Create(Report report)
        {
            await _mongoCollection.InsertOneAsync(report);
            return report;
        }

        public async Task<List<Report>> List()
        {
            List<Report> reports = await _mongoCollection.Find(report => true).ToListAsync();
            return reports;
        }
    }
}
