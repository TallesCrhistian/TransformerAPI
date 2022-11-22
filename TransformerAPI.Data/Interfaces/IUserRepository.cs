using System.Threading.Tasks;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Insert(User user);
    }
}
