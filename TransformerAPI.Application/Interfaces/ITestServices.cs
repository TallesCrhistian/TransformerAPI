using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Interfaces
{
    public interface ITestServices
    {
        Task<ServiceResponseDTO<TestDTO>> Create(TestDTO testDTO);
        Task<ServiceResponseDTO<TestDTO>> Update(TestDTO testDTO);
        Task<ServiceResponseDTO<TestDTO>> Delete(int id);
        Task<ServiceResponseDTO<TestDTO>> Read(int id);
    }
}
