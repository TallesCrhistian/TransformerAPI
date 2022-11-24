using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Interfaces
{
    public interface ITransformerServices
    {
        Task<ServiceResponseDTO<TransformerDTO>> Create(TransformerDTO transformerDTO);
        Task<ServiceResponseDTO<TransformerDTO>> Read(string id);
        Task<ServiceResponseDTO<TransformerDTO>> Update(TransformerDTO transformerDTO, string id);
        Task<ServiceResponseDTO<TransformerDTO>> Delete(string id);
    }
}
