using MongoDB.Driver;
using System.Threading.Tasks;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly IMongoCollection<Test> _mongoCollection;

        public TestRepository(ITransformerDatabaseSettings transformerDatabaseSettings)
        {
            var client = new MongoClient(transformerDatabaseSettings.ConnectionString);
            var database = client.GetDatabase(transformerDatabaseSettings.DatabaseName);

            _mongoCollection = database.GetCollection<Test>(transformerDatabaseSettings.TransformerCollectionName);
        }

        public async Task<Test> Create(Test test)
        {
            await _mongoCollection.InsertOneAsync(test);
            return test;
        }

        public async Task<Test> Read(string id)
        {
            Test test = await _mongoCollection.Find<Test>(test => test.Id == id).FirstOrDefaultAsync();
            return test;
        }

        public async Task<Test> Update(Test test, string id)
        {
            await _mongoCollection.ReplaceOneAsync(test => test.Id == id, test);
            return test;
        }

        public async Task<Test> Delete(string id)
        {
            await _mongoCollection.DeleteOneAsync(test => test.Id == id);
            Test test = new();

            return test;
        }
    }
}
