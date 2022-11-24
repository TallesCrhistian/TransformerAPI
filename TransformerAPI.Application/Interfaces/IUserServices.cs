using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Interfaces
{
    public interface IUserServices
    {
        Task<ServiceResponseDTO<UserDTO>> Create(UserDTO userDTO);
        Task<ServiceResponseDTO<UserDTO>> Read(string id);
        Task<ServiceResponseDTO<UserDTO>> Update(UserDTO userDTO, string id);
        Task<ServiceResponseDTO<UserDTO>> Delete(string id);
    }
}
