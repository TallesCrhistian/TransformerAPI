using System.Threading.Tasks;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Interfaces
{
    public interface ITestRepository
    {
        Task<Test> Create(Test test);
        Task<Test> Update(Test test, string id);
        Task<Test> Delete(string id);
        Task<Test> Read(string id);
    }
}
