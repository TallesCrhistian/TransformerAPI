using System.Threading.Tasks;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Interfaces
{
    public interface ITestRepository
    {
        Task<Test> Create(Test test);
        Task<Test> Update(Test test);
        Task<Test> Delete(int id);
        Task<Test> Read(int id);
    }
}
