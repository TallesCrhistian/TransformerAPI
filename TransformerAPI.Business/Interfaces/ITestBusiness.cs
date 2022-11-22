using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business.Interfaces
{
    public interface ITestBusiness
    {
        Task<TestDTO> Create(TestDTO testDTO);
        Task<TestDTO> Update(TestDTO testDTO);
        Task<TestDTO> Delete(int id);
        Task<TestDTO> Read(int id);
    }
}
