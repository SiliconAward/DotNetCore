using SiliconAward.DataAccess.Data;
using SiliconAward.DataAccess.Entities;
using SiliconAward.DataAccess.Repositories.BaseRepositories;
using SiliconAward.DataAccess.ViewModels.Competition;
using SiliconAward.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconAward.DataAccess.Repositories.CompetitionRepositories
{
    public class CompetitionRepository : BaseRepository<Competition>, ICompetitionRepository
    {
        private readonly ApplicationDbContext _context;
        public CompetitionRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IOrderedQueryable<CompetitionViewModel> GetCompetitionIQueryable()
        {
            try
            {

                var query = _context.Competitions.Select(p => new CompetitionViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Description = p.Description,
                    StartCompetition = p.StartCompetition,
                    EndCompetition = p.EndCompetition
                }).OrderBy(p=>p.Id);
                return query;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<int> Create(CompetitionViewModel model)
        {
            try
            {
                var result = await Create(new Competition()
                {
                    CreatedTime = model.CreatedTime,
                    Title = model.Title,
                    Description = model.Description,
                    StartCompetition = model.StartCompetition,
                    EndCompetition = model.EndCompetition
                });
                return result.Id;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }

}
