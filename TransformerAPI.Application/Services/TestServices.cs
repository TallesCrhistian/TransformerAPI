﻿using System;
using System.Threading.Tasks;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Services
{
    public class TestServices : ITestServices
    {
        private readonly ITestBusiness _testBusiness;

        public TestServices(ITestBusiness testBusiness)
        {
            _testBusiness = testBusiness;
        }
        public async Task<ServiceResponseDTO<TestDTO>> Create(TestDTO testDTO)
        {
            ServiceResponseDTO<TestDTO> serviceResponseDTO = new ServiceResponseDTO<TestDTO>();
            try
            {
                serviceResponseDTO.Dados = await _testBusiness.Create(testDTO);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }

        public async Task<ServiceResponseDTO<TestDTO>> Update(TestDTO testDTO)
        {
            ServiceResponseDTO<TestDTO> serviceResponseDTO = new ServiceResponseDTO<TestDTO>();
            try
            {
                serviceResponseDTO.Dados = await _testBusiness.Update(testDTO);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }
        public async Task<ServiceResponseDTO<TestDTO>> Delete(int id)
        {
            ServiceResponseDTO<TestDTO> serviceResponseDTO = new ServiceResponseDTO<TestDTO>();
            try
            {
                serviceResponseDTO.Dados = await _testBusiness.Delete(id);
            }
            catch (Exception ex)
            {
                serviceResponseDTO.Sucesso = false;
                serviceResponseDTO.Mensagem = ex.GetBaseException().Message;
            }
            return serviceResponseDTO;
        }
        public async Task<ServiceResponseDTO<TestDTO>> Read(int id)
        {
            ServiceResponseDTO<TestDTO> serviceResponseDTO = new ServiceResponseDTO<TestDTO>();
            try
            {
                serviceResponseDTO.Dados = await _testBusiness.Read(id);
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
