using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;
using TransformerAPI.Shared.Filters;

namespace TransformerAPI.Business.Interfaces
{
    public interface IReportBusiness
    {
        Task<ReportDTO> Create(TestDTO testDTO);
        Task<List<ReportDTO>> List(ReportFilter reportFilter);
    }
}
