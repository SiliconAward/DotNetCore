using SiliconAward.DataAccess.ViewModels.AspNetUser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiliconAward.Service.UserServices
{
    public interface IUserService
    {
        Task<bool> Register(RegisterViewModel model);
        int Login(LoginViewModel model);

    }
}
