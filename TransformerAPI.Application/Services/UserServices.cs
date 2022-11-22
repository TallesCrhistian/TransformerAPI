using System;
using System.Threading.Tasks;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserBusiness _userBusiness;
        public UserServices(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        public async Task<ServiceResponseDTO<UserDTO>> Insert(UserDTO userDTO)
        {
            ServiceResponseDTO<UserDTO> serviceResponseDTO = new ServiceResponseDTO<UserDTO>();
            try
            {
                serviceResponseDTO.Dados = await _userBusiness.Insert(userDTO);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }
    }
}
