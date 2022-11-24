using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business.Interfaces
{
    public interface ITransformerBusiness
    {
        Task<TransformerDTO> Create(TransformerDTO transformerDTO);
        Task<TransformerDTO> Update(TransformerDTO transformerDTO, string id);
        Task<TransformerDTO> Delete(string id);
        Task<TransformerDTO> Read(string id);
    }
}
