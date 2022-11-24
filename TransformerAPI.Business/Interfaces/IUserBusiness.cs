using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business.Interfaces
{
    public interface IUserBusiness
    {
        Task<UserDTO> Create(UserDTO userDTO);
        Task<UserDTO> Read(string id);
        Task<UserDTO> Update(UserDTO userDTO, string id);
        Task<UserDTO> Delete(string id);
    }
}
