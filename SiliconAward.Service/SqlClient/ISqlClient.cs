using SiliconAward.Service.CompetitionServices;
using SiliconAward.Service.CustomLogServices;
using SiliconAward.Service.UserServices;

namespace SiliconAward.Service.SqlClient
{
    public interface ISqlClient
    {
        ICustomLogService CustomLogService { get; set; }
        IUserService UserService { get; set; }
        ICompetitionService CompetitionService { get; set; }

    }
}
