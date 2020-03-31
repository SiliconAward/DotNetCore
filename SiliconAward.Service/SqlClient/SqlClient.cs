using Microsoft.AspNetCore.Identity;
using NToastNotify;
using SiliconAward.DataAccess.Entities.Identities;
using SiliconAward.DataAccess.SqlClient;
using SiliconAward.Service.CompetitionServices;
using SiliconAward.Service.CustomLogServices;
using SiliconAward.Service.UserServices;

namespace SiliconAward.Service.SqlClient
{
    public class SqlClient:ISqlClient
    {

        public SqlClient(IWrapper wrapper, UserManager<AspNetUsers> userManager  ,IToastNotification _toastNotification)
        {
            CustomLogService = new CustomLogService(wrapper, _toastNotification);
            UserService = new UserService(userManager, _toastNotification);
            CompetitionService = new CompetitionService(wrapper, _toastNotification);
        }
        public ICustomLogService CustomLogService { get; set; }
        public IUserService UserService { get; set; }
        public ICompetitionService CompetitionService { get; set; }
    }
}
