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

        public async Task<User> Update(User user, string id)
        {
            await _mongoCollection.ReplaceOneAsync(user => user.Id == id, user);
            return user;
        }

        public async Task<User> Delete(string id)
        {
            await _mongoCollection.DeleteOneAsync(user => user.Id == id);
            User user = new User();

            return user;
        }

        public async Task<User> Read(string id)
        {
            User user = await _mongoCollection.Find<User>(user => user.Id == id).FirstOrDefaultAsync();
            return user;

        }
    }
}
