using MongoDB.Driver;
using System;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Context
{
    public class MongoDbContext
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public bool IsSSL { get; set; }

        private IMongoDatabase _database { get; }

        public MongoDbContext()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                }
                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        }

        public IMongoCollection<User> User
        {
            get
            {
                return _database.GetCollection<User>("User");
            }
        }
        public IMongoCollection<Transformer> Transformer
        {
            get
            {
                return _database.GetCollection<Transformer>("Transformer");
            }
        }
        public IMongoCollection<Test> Test
        {
            get
            {
                return _database.GetCollection<Test>("Test");
            }
        }

    }
}

