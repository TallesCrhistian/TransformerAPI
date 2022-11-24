using MongoDB.Driver;
using System.Threading.Tasks;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Repository
{
    public class TransformerRepository : ITransformerRepository
    {
        private readonly IMongoCollection<Transformer> _mongoCollection;

        public TransformerRepository(ITransformerDatabaseSettings transformerDatabaseSettings)
        {
            var client = new MongoClient(transformerDatabaseSettings.ConnectionString);
            var database = client.GetDatabase(transformerDatabaseSettings.DatabaseName);

            _mongoCollection = database.GetCollection<Transformer>(transformerDatabaseSettings.TransformerCollectionName);
        }
        public async Task<Transformer> Create(Transformer transformer)
        {
            await _mongoCollection.InsertOneAsync(transformer);
            return transformer;
        }
        public async Task<Transformer> Read(string id)
        {
            Transformer transformer = await _mongoCollection.Find<Transformer>(transformer => transformer.Id == id).FirstOrDefaultAsync();
            return transformer;
        }
        public async Task<Transformer> Update(Transformer transformer, string id)
        {
            await _mongoCollection.ReplaceOneAsync(user => user.Id == id, transformer);
            return transformer;
        }

        public async Task<Transformer> Delete(string id)
        {
            await _mongoCollection.DeleteOneAsync(transformer => transformer.Id == id);
            Transformer transformer = new();

            return transformer;
        }


    }
}
