using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;
using TransformerAPI.Shared.DTOs;
using TransformerAPI.Shared.Filters;

namespace TransformerAPI.Business
{
    public class ReportBusiness : IReportBusiness
    {
        public readonly IReportRepository _reportRepository;
        public readonly IMapper _mapper;
        public ReportBusiness(IReportRepository reportRepository, IMapper mapper)
        {
            _reportRepository = reportRepository;
            _mapper = mapper;
        }

        public async Task<ReportDTO> Create(TestDTO testDTO)
        {
            ReportDTO reportDTO = await AddValues(testDTO);
            Report report = _mapper.Map<Report>(reportDTO);
            report = await _reportRepository.Create(report);
            return _mapper.Map<ReportDTO>(report);
        }

        public async Task<List<ReportDTO>> List(ReportFilter reportFilter)
        {
            List<Report> report = await _reportRepository.List(reportFilter);
            List<ReportDTO> reportDTO = _mapper.Map<List<ReportDTO>>(report);
            return reportDTO;
        }
        public async Task<ReportDTO> AddValues(TestDTO testDTO)
        {
            ReportDTO reportDTO = new ReportDTO();
            reportDTO.Name = testDTO.Name;
            reportDTO.Status = testDTO.Status;

            return reportDTO;
        }
    }
}
