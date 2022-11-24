using System.Threading.Tasks;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
        Task<User> Update(User user, string id);
        Task<User> Delete(string id);
        Task<User> Read(string id);
    }
}
