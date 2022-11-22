using System.Threading.Tasks;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Repository
{
    public class TransformerRepository : ITransformerRepository
    {
        public Task<Transformer> Create(Transformer transformer)
        {
            throw new System.NotImplementedException();
        }

        public Task<Transformer> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Transformer> Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Transformer> Update(Transformer transformer)
        {
            throw new System.NotImplementedException();
        }
    }
}
