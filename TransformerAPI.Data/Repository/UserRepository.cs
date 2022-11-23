using MongoDB.Driver;
using System.Threading.Tasks;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _mongoCollection;

        public UserRepository(ITransformerDatabaseSettings transformerDatabaseSettings)
        {
            var client = new MongoClient(transformerDatabaseSettings.ConnectionString);
            var database = client.GetDatabase(transformerDatabaseSettings.DatabaseName);

            _mongoCollection = database.GetCollection<User>(transformerDatabaseSettings.TransformerCollectionName);
        }
        public async Task<User> Create(User user)
        {
           await _mongoCollection.InsertOneAsync(user);
            return user;
        }

        public Task<User> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
