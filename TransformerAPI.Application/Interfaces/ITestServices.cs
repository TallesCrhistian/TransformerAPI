using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Interfaces
{
    public interface ITestServices
    {
        Task<ServiceResponseDTO<TestDTO>> Create(TestDTO testDTO);
        Task<ServiceResponseDTO<TestDTO>> Read(string id);
        Task<ServiceResponseDTO<TestDTO>> Update(TestDTO testDTO, string id);
        Task<ServiceResponseDTO<TestDTO>> Delete(string id);
    }
}
