using SiliconAward.DataAccess.ViewModels.CustomLogViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiliconAward.Service.CustomLogServices
{
    public  interface ICustomLogService
    {
        Task<bool> Add(CustomLogViewModel model);
        Task<bool> Update(CustomLogViewModel model);
        Task<bool> Delete(int id);
        Task<List<CustomLogViewModel>> GetList();
        Task<CustomLogViewModel> GetById(int id);

    }
}
