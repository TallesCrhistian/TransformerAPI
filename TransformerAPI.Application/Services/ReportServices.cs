﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Shared.DTOs;
using TransformerAPI.Shared.Filters;

namespace TransformerAPI.Application.Services
{
    public class ReportServices : IReportServices
    {
        private readonly IReportBusiness _reportBusiness;
        public ReportServices(IReportBusiness reportBusiness)
        {
            _reportBusiness = reportBusiness;
        }
        public async Task<ServiceResponseDTO<List<ReportDTO>>> List(ReportFilter reportFilter)
        {

            ServiceResponseDTO<List<ReportDTO>> serviceResponseDTO = new ServiceResponseDTO<List<ReportDTO>>();
            try
            {
                serviceResponseDTO.Dados = await _reportBusiness.List(reportFilter);

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
