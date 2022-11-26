using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Application.Interfaces
{
    public interface IReportServices
    {
        Task<ServiceResponseDTO<List<ReportDTO>>> List();
    }
}
