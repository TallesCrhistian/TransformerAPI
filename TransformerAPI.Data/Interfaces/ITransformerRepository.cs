using System.Threading.Tasks;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Interfaces
{
    public interface ITransformerRepository
    {
        Task<Transformer> Create(Transformer transformer);
        Task<Transformer> Update(Transformer transformer);
        Task<Transformer> Delete(int id);
        Task<Transformer> Read(int id);
    }
}
