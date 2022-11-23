using System.Collections.Generic;
using System.Threading.Tasks;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;
using TransformerAPI.Shared.Filters;

namespace TransformerAPI.Data.Repository
{
    public class ReportRepository : IReportRepository
    {
        public Task<Report> Create(Report report)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Report>> List(ReportFilter reportFilter)
        {
            throw new System.NotImplementedException();
        }
    }
}
