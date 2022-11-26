using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportServices _reportServices;
        private readonly IMapper _mapper;

        public ReportController(IReportServices reportServices, IMapper mapper)
        {
            _reportServices = reportServices;
            _mapper = mapper;
        }

        [HttpGet]
        [Route(nameof(List))]
        public async Task<IActionResult> List()
        {
            ServiceResponseDTO<List<ReportDTO>> serviceResponseDTO = await _reportServices.List();
            return Ok(serviceResponseDTO);
        }
    }
}
