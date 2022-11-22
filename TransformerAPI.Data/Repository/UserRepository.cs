using System.Threading.Tasks;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public Task<User> Insert(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
