using SiliconAward.DataAccess.Data;
using SiliconAward.DataAccess.Repositories.CompetitionRepositories;
using SiliconAward.DataAccess.Repositories.CustomLogRepositories;

namespace SiliconAward.DataAccess.SqlClient
{
    public class Wrapper: IWrapper
    {
        private readonly ApplicationDbContext _context;
        public Wrapper(ApplicationDbContext context)
        {
            _context = context;
            CustomLogRepository = new CustomLogRepository(_context);
            CompetitionRepository = new CompetitionRepository(_context);
        }
        public ICustomLogRepository CustomLogRepository { get; set; }
        public ICompetitionRepository CompetitionRepository { get; set; }
    }
}
