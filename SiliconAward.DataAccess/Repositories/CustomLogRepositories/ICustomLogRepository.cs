using SiliconAward.DataAccess.Entities;
using SiliconAward.DataAccess.ViewModels.CustomLogViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiliconAward.DataAccess.Repositories.CustomLogRepositories
{
    public interface ICustomLogRepository
    {
        Task<bool> Add(CustomLogViewModel model);
        Task<bool> Update(CustomLogViewModel model);
        Task<bool> Delete(CustomLogViewModel model);
        Task<List<CustomLogViewModel>> GetList();
        Task<CustomLogViewModel> GetById(int id);
        Task<CustomLog> IsExist(int id);
        CustomLog MapViewModelToModel(CustomLogViewModel model);

    }
}
