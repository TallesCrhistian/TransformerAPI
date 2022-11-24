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
        public async Task<ServiceResponseDTO<UserDTO>> Create(UserDTO userDTO)
        {
            ServiceResponseDTO<UserDTO> serviceResponseDTO = new ServiceResponseDTO<UserDTO>();
            try
            {
                serviceResponseDTO.Dados = await _userBusiness.Create(userDTO);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }

        public async Task<ServiceResponseDTO<UserDTO>> Update(UserDTO userDTO, string id)
        {
            ServiceResponseDTO<UserDTO> serviceResponseDTO = new ServiceResponseDTO<UserDTO>();
            try
            {
                serviceResponseDTO.Dados = await _userBusiness.Update(userDTO, id);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }
        public async Task<ServiceResponseDTO<UserDTO>> Delete(string id)
        {
            ServiceResponseDTO<UserDTO> serviceResponseDTO = new ServiceResponseDTO<UserDTO>();
            try
            {
                serviceResponseDTO.Dados = await _userBusiness.Delete(id);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }
        public async Task<ServiceResponseDTO<UserDTO>> Read(string id)
        {
            ServiceResponseDTO<UserDTO> serviceResponseDTO = new ServiceResponseDTO<UserDTO>();
            try
            {
                serviceResponseDTO.Dados = await _userBusiness.Read(id);
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
