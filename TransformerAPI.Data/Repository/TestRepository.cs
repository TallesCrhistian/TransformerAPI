using System;
using System.Threading.Tasks;
using TransformerAPI.Data.Context;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly MongoDbContext _mongoDbContext;
        public TestRepository(MongoDbContext mongoDbContext)
        {
            _mongoDbContext = mongoDbContext;
        }

        public async Task<Test> Create(Test test)
        {
            test.Id = Guid.NewGuid();

            _mongoDbContext.Test.InsertOne(test);
            return test;
        }

        public Task<Test> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Test> Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Test> Update(Test test)
        {
            throw new System.NotImplementedException();
        }
    }
}
