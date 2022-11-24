using System;
using System.Threading.Tasks;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Services
{
    public class TransformerServices : ITransformerServices
    {
        private readonly ITransformerBusiness _transformerBusiness;

        public TransformerServices(ITransformerBusiness transformerBusiness)
        {
            _transformerBusiness = transformerBusiness;
        }
        public async Task<ServiceResponseDTO<TransformerDTO>> Create(TransformerDTO transformerDTO)
        {
            ServiceResponseDTO<TransformerDTO> serviceResponseDTO = new ServiceResponseDTO<TransformerDTO>();
            try
            {
                serviceResponseDTO.Dados = await _transformerBusiness.Create(transformerDTO);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }

        public async Task<ServiceResponseDTO<TransformerDTO>> Update(TransformerDTO transformerDTO, string id)
        {
            ServiceResponseDTO<TransformerDTO> serviceResponseDTO = new ServiceResponseDTO<TransformerDTO>();
            try
            {
                serviceResponseDTO.Dados = await _transformerBusiness.Update(transformerDTO, id);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }
        public async Task<ServiceResponseDTO<TransformerDTO>> Delete(string id)
        {
            ServiceResponseDTO<TransformerDTO> serviceResponseDTO = new ServiceResponseDTO<TransformerDTO>();
            try
            {
                serviceResponseDTO.Dados = await _transformerBusiness.Delete(id);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }
        public async Task<ServiceResponseDTO<TransformerDTO>> Read(string id)
        {
            ServiceResponseDTO<TransformerDTO> serviceResponseDTO = new ServiceResponseDTO<TransformerDTO>();
            try
            {
                serviceResponseDTO.Dados = await _transformerBusiness.Read(id);
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
