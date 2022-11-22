using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Interfaces
{
    public interface ITransformerServices
    {
        Task<ServiceResponseDTO<TransformerDTO>> Create(TransformerDTO transformerDTO);
        Task<ServiceResponseDTO<TransformerDTO>> Update(TransformerDTO transformerDTO);
        Task<ServiceResponseDTO<TransformerDTO>> Delete(int id);
        Task<ServiceResponseDTO<TransformerDTO>> Read(int id);
    }
}
