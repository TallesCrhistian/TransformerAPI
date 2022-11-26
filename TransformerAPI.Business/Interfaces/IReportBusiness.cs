using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business.Interfaces
{
    public interface IReportBusiness
    {
        Task<ReportDTO> Create(TestDTO testDTO);
        Task<List<ReportDTO>> List();
    }
}
