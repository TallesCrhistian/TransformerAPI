using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business.Interfaces
{
    public interface ITestBusiness
    {
        Task<TestDTO> Create(TestDTO testDTO);
        Task<TestDTO> Read(string id);
        Task<TestDTO> Update(TestDTO testDTO, string id);
        Task<TestDTO> Delete(string id);
    }
}
