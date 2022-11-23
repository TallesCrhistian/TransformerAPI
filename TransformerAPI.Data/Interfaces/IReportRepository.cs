using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Entities;
using TransformerAPI.Shared.Filters;

namespace TransformerAPI.Data.Interfaces
{
    public interface IReportRepository
    {
        Task<List<Report>> List(ReportFilter reportFilter);
        Task<Report> Create(Report report);
    }
}
