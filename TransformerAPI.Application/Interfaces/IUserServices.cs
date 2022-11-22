using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Interfaces
{
    public interface IUserServices
    {
        Task<ServiceResponseDTO<UserDTO>> Insert(UserDTO userDTO);
    }
}
