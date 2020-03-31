using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NToastNotify;
using SiliconAward.DataAccess.ViewModels.AspNetUser;
using SiliconAward.DataAccess.ViewModels.CustomLogViewModel;
using SiliconAward.Infrastructure.SecurityExtensions;
using SiliconAward.Models;
using SiliconAward.Service.SqlClient;

namespace SiliconAward.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISqlClient _uow;
        public IConfiguration Configuration { get; }
        private readonly IToastNotification _toastNotification;


        public HomeController(ILogger<HomeController> logger, ISqlClient uow, IConfiguration configuration, IToastNotification toastNotification)
        {
            _logger = logger;
            _uow = uow;
            Configuration = configuration;
            _toastNotification = toastNotification;
        }
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("[action]")]
        public IActionResult ContactUs()
        {
            return View(new ContactUsViewModel() { CaptchaSitekey = Configuration.GetValue<string>("recpatchaSecretKey:sitekey") });
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ContactUs(ContactUsViewModel model)
        {
            #region reCaptcha
            var captchaResponse = await SecurityExtensions.ValidateRecaptcha<RecaptchaResponseModel>(Request,
                Configuration.GetValue<string>("recpatchaSecretKey:secretkey"));
            if (!captchaResponse.Success)
            {
                ModelState.AddModelError("recaptchaerror", "reCAPTCHA Error occured. Please try again");
                _toastNotification.AddWarningToastMessage("please do reCaptcha ");
                return View(new ContactUsViewModel() { CaptchaSitekey = Configuration.GetValue<string>("recpatchaSecretKey:sitekey") });
            }
            #endregion
         
            await _uow.CustomLogService.Add(new CustomLogViewModel()
            {
                LogType = "ContactUs",
                Message1 = model.SubjectId.ToString(),
                Message2 = model.Message
            });
            return View(new ContactUsViewModel() { CaptchaSitekey = Configuration.GetValue<string>("recpatchaSecretKey:sitekey") });
        }

        [HttpGet("[action]")]
        public IActionResult AboutUs()
        {
            return View();
        }


    }
}
