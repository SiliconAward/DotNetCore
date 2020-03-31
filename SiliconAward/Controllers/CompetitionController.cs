using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Kendo.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using SiliconAward.DataAccess.SqlClient;
using SiliconAward.DataAccess.ViewModels;
using SiliconAward.DataAccess.ViewModels.Competition;

using SiliconAward.Service.SqlClient;

namespace SiliconAward.Controllers
{
    [Route("[controller]")]
    public class CompetitionController : Controller
    {
        private readonly ISqlClient _uow;
        private readonly IToastNotification _toastNotification;


        public CompetitionController(ISqlClient uow, IToastNotification toastNotification)
        {
            _uow = uow;
            _toastNotification = toastNotification;
        }
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("[action]")]
        public ActionResult CustomAjaxBinding_Read([DataSourceRequest] DataSourceRequest request)
        {

            IQueryable<CompetitionViewModel> competitions = _uow.CompetitionService.GetCompetitionIQueryable();
            competitions = competitions.ApplyCompetitionsFiltering(request.Filters);
            var total = competitions.Count();
            competitions = competitions.OrderByDescending(p => p.Id);
            competitions = competitions.ApplyCompetitionsPaging(request.Page, request.PageSize);
            IEnumerable data = competitions.ToList();
            var result = new DataSourceResult() { Data = data, Total = total };

            return Json(result);
        }

        [HttpGet("[action]")]
        public IActionResult Create()
        {
            return View(new CompetitionViewModel());
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CompetitionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newId = await _uow.CompetitionService.Create(model);
                if (newId == 0)
                    return View(new CompetitionViewModel());
                else
                    return RedirectToAction("Index");
            }
            return View(new CompetitionViewModel());
        }

        [HttpGet("[action]")]
        public JsonResult GetRewards(string text)
        {
            //test
            var list = new List<DropDownModel>() {
                new DropDownModel() { Value = "1", Text = "reward 1" },
                new DropDownModel() { Value = "2", Text = "reward 2" },
                new DropDownModel() { Value = "3", Text = "reward 3" } };

            return Json(list.ToList());
        }
        [HttpGet("[action]")]
        public JsonResult GetSkillGroups(string text)
        {

            //test
            var list = new List<DropDownModel>() {
                new DropDownModel() { Value = "1", Text = "SkillGroup 1" },
                new DropDownModel() { Value = "2", Text = "SkillGroup 2" },
                new DropDownModel() { Value = "3", Text = "SkillGroup 3" } };

            return Json(list.ToList());
        }
        [HttpGet("[action]")]
        public JsonResult GetSkillFields(int? skillGroups)
        {
            //test
            var list = new List<DropDownModel>() {
                new DropDownModel() { Value = "1", Text = "SkillField 1" },
                new DropDownModel() { Value = "2", Text = "SkillField 2" },
                new DropDownModel() { Value = "3", Text = "SkillField 3" } };

            return Json(list.ToList());
        }
    }
}
#region Competition Grid
public static class AjaxCustomBindingExtensions
{
    public static IQueryable<CompetitionViewModel> ApplyCompetitionsPaging(this IQueryable<CompetitionViewModel> data, int page, int pageSize)
    {
        if (pageSize > 0 && page > 0)
        {
            data = data.Skip((page - 1) * pageSize);
        }

        data = data.Take(pageSize);

        return data;
    }

    //public static IEnumerable ApplyCompetitionsGrouping(this IQueryable<CompetitionViewModel> data, IList<GroupDescriptor>
    //    groupDescriptors)
    //{
    //    if (groupDescriptors != null && groupDescriptors.Any())
    //    {
    //        Func<IEnumerable<CompetitionViewModel>, IEnumerable<AggregateFunctionsGroup>> selector = null;
    //        foreach (var group in groupDescriptors.Reverse())
    //        {
    //            if (selector == null)
    //            {
    //                if (group.Member == "ShipCity")
    //                {
    //                    selector = Competitions => BuildInnerGroup(Competitions, o => o.ShipCity);
    //                }
    //                else if (group.Member == "ShipAddress")
    //                {
    //                    selector = Competitions => BuildInnerGroup(Competitions, o => o.ShipAddress);
    //                }
    //                else if (group.Member == "ShipName")
    //                {
    //                    selector = Competitions => BuildInnerGroup(Competitions, o => o.ShipName);
    //                }
    //                else if (group.Member == "ShipCountry")
    //                {
    //                    selector = Competitions => BuildInnerGroup(Competitions, o => o.ShipCountry);
    //                }
    //            }
    //            else
    //            {
    //                if (group.Member == "ShipCity")
    //                {
    //                    selector = BuildGroup(o => o.ShipCity, selector);
    //                }
    //                else if (group.Member == "ShipAddress")
    //                {
    //                    selector = BuildGroup(o => o.ShipAddress, selector);
    //                }
    //                else if (group.Member == "ShipName")
    //                {
    //                    selector = BuildGroup(o => o.ShipName, selector);
    //                }
    //                else if (group.Member == "ShipCountry")
    //                {
    //                    selector = BuildGroup(o => o.ShipCountry, selector);
    //                }
    //            }
    //        }

    //        return selector.Invoke(data).ToList();
    //    }

    //    return data.ToList();
    //}

    private static Func<IEnumerable<CompetitionViewModel>, IEnumerable<AggregateFunctionsGroup>>
        BuildGroup<T>(Expression<Func<CompetitionViewModel, T>> groupSelector, Func<IEnumerable<CompetitionViewModel>,
        IEnumerable<AggregateFunctionsGroup>> selectorBuilder)
    {
        var tempSelector = selectorBuilder;
        return g => g.GroupBy(groupSelector.Compile())
                     .Select(c => new AggregateFunctionsGroup
                     {
                         Key = c.Key,
                         HasSubgroups = true,
                         Member = groupSelector.MemberWithoutInstance(),
                         Items = tempSelector.Invoke(c).ToList()
                     });
    }

    private static IEnumerable<AggregateFunctionsGroup> BuildInnerGroup<T>(IEnumerable<CompetitionViewModel>
        group, Expression<Func<CompetitionViewModel, T>> groupSelector)
    {
        return group.GroupBy(groupSelector.Compile())
                .Select(i => new AggregateFunctionsGroup
                {
                    Key = i.Key,
                    Member = groupSelector.MemberWithoutInstance(),
                    Items = i.ToList()
                });
    }

    //public static IQueryable<CompetitionViewModel> ApplyCompetitionsSorting(this IQueryable<CompetitionViewModel> data,
    //            IList<GroupDescriptor> groupDescriptors, IList<SortDescriptor> sortDescriptors)
    //{
    //    if (groupDescriptors != null && groupDescriptors.Any())
    //    {
    //        foreach (var groupDescriptor in groupDescriptors.Reverse())
    //        {
    //            data = AddSortExpression(data, groupDescriptor.SortDirection, groupDescriptor.Member);
    //        }
    //    }

    //    if (sortDescriptors != null && sortDescriptors.Any())
    //    {
    //        foreach (SortDescriptor sortDescriptor in sortDescriptors)
    //        {
    //            data = AddSortExpression(data, sortDescriptor.SortDirection, sortDescriptor.Member);
    //        }
    //    }

    //    return data;
    //}

    //private static IQueryable<CompetitionViewModel> AddSortExpression(IQueryable<CompetitionViewModel> data, ListSortDirection
    //            sortDirection, string memberName)
    //{
    //    if (sortDirection == ListSortDirection.Ascending)
    //    {
    //        switch (memberName)
    //        {
    //            case "CompetitionID":
    //                data = data.CompetitionBy(competition => competition.CompetitionID);
    //                break;
    //            case "ShipCity":
    //                data = data.CompetitionBy(competition => competition.ShipCity);
    //                break;
    //            case "ShipCountry":
    //                data = data.CompetitionBy(competition => competition.ShipCountry);
    //                break;
    //            case "ShipName":
    //                data = data.CompetitionBy(competition => competition.ShipName);
    //                break;
    //        }
    //    }
    //    else
    //    {
    //        switch (memberName)
    //        {
    //            case "CompetitionID":
    //                data = data.CompetitionByDescending(Competition => Competition.CompetitionID);
    //                break;
    //            case "ShipCity":
    //                data = data.CompetitionByDescending(Competition => Competition.ShipCity);
    //                break;
    //            case "ShipCountry":
    //                data = data.CompetitionByDescending(Competition => Competition.ShipCountry);
    //                break;
    //            case "ShipName":
    //                data = data.CompetitionByDescending(Competition => Competition.ShipName);
    //                break;
    //        }
    //    }
    //    return data;
    //}

    public static IQueryable<CompetitionViewModel> ApplyCompetitionsFiltering(this IQueryable<CompetitionViewModel> data,
       IList<IFilterDescriptor> filterDescriptors)
    {
        if (filterDescriptors.Any())
        {
            data = data.Where(ExpressionBuilder.Expression<CompetitionViewModel>(filterDescriptors, false));
        }
        return data;
    }
}
#endregion
