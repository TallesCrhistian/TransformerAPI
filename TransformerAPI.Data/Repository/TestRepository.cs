using System.Threading.Tasks;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Repository
{
    public class TestRepository : ITestRepository
    {
        public Task<Test> Create(Test test)
        {
            throw new System.NotImplementedException();
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
