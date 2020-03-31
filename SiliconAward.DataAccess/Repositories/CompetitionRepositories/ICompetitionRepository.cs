using SiliconAward.DataAccess.ViewModels.Competition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconAward.DataAccess.Repositories.CompetitionRepositories
{
    public interface ICompetitionRepository
    {
        IOrderedQueryable<CompetitionViewModel> GetCompetitionIQueryable();
        Task<int> Create(CompetitionViewModel model);

    }
}
