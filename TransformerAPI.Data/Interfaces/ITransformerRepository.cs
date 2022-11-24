using System.Threading.Tasks;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Interfaces
{
    public interface ITransformerRepository
    {
        Task<Transformer> Create(Transformer transformer);
        Task<Transformer> Update(Transformer transformer, string id);
        Task<Transformer> Delete(string id);
        Task<Transformer> Read(string id);
    }
}
