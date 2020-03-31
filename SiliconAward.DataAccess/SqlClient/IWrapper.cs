using SiliconAward.DataAccess.Repositories.CompetitionRepositories;
using SiliconAward.DataAccess.Repositories.CustomLogRepositories;

namespace SiliconAward.DataAccess.SqlClient
{
    public interface IWrapper
    {
        ICustomLogRepository CustomLogRepository { get; set; }
        ICompetitionRepository CompetitionRepository { get; set; }
    }
}
