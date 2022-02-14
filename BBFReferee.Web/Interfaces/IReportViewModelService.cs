using BBFReferee.Web.Models;
using System.Collections.Generic;

namespace BBFReferee.Web.Interfaces
{
    public interface IReportViewModelService
    {
        int Add(ReportViewModel reportViewModel);
        void Edit(ReportViewModel reportViewModel);
        IEnumerable<ReportViewModel> GetAll();
        ReportViewModel GetById(int id);
    }
}
