using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Entities;

namespace TransformerAPI.Data.Interfaces
{
    public interface IReportRepository
    {
        Task<List<Report>> List();
        Task<Report> Create(Report report);
    }
}
