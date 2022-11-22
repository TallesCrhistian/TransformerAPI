using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business.Interfaces
{
    public interface IUserBusiness
    {
        Task<UserDTO> Insert(UserDTO userDTO);
    }
}
