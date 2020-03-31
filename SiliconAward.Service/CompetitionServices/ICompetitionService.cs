using SiliconAward.DataAccess.ViewModels.Competition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconAward.Service.CompetitionServices
{
    public interface ICompetitionService
    {
        IOrderedQueryable<CompetitionViewModel> GetCompetitionIQueryable();
        Task<int> Create(CompetitionViewModel model);

    }
}
