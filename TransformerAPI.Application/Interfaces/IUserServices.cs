using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Interfaces
{
    public interface IUserServices
    {
        Task<ServiceResponseDTO<UserDTO>> Create(UserDTO userDTO);
        Task<ServiceResponseDTO<UserDTO>> Update(UserDTO userDTO);
        Task<ServiceResponseDTO<UserDTO>> Delete(int id);
        Task<ServiceResponseDTO<UserDTO>> Read(int id);
    }
}
