using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business.Interfaces
{
    public interface ITransformerBusiness
    {
        Task<TransformerDTO> Create(TransformerDTO transformerDTO);
        Task<TransformerDTO> Update(TransformerDTO transformerDTO);
        Task<TransformerDTO> Delete(int id);
        Task<TransformerDTO> Read(int id);
    }
}
