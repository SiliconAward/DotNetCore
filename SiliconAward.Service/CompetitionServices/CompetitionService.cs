using NToastNotify;
using SiliconAward.DataAccess.Data;
using SiliconAward.DataAccess.Entities;
using SiliconAward.DataAccess.Repositories.BaseRepositories;
using SiliconAward.DataAccess.SqlClient;
using SiliconAward.DataAccess.ViewModels.Competition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconAward.Service.CompetitionServices
{
    public class CompetitionService: ICompetitionService
    {
      
        private readonly IWrapper _dataAccess;
        private readonly IToastNotification _toastNotification;
        public CompetitionService(IWrapper uow, IToastNotification toastNotification)
        {
            _dataAccess = uow;
            _toastNotification = toastNotification;
        }
        public IOrderedQueryable<CompetitionViewModel> GetCompetitionIQueryable()
        {
            try
            {
               return _dataAccess.CompetitionRepository.GetCompetitionIQueryable();
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
                model.CreatedTime = DateTime.Now;
                var newId = await _dataAccess.CompetitionRepository.Create(model);
                if (newId == 0)
                    _toastNotification.AddErrorToastMessage("Operation failed!");
                else
                    _toastNotification.AddSuccessToastMessage("Operation was succeeded");

                return newId;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
