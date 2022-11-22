using System.Threading.Tasks;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public Task<User> Create(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
