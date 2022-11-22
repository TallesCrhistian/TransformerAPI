using System.Threading.Tasks;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> Delete(int id);
        Task<User> Read(int id);
    }
}
