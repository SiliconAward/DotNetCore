using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SiliconAward.DataAccess.Entities.Identities;
using SiliconAward.DataAccess.ViewModels.AspNetUser;
using SiliconAward.Service.SqlClient;

namespace SiliconAward.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly UserManager<AspNetUsers> _userManager;
        private readonly ISqlClient _uow;

        public UserController(ISqlClient uow,
            UserManager<AspNetUsers> userManager
            )
        {
            _uow = uow;
            _userManager = userManager;
        }

        public async Task<AspNetUsers> CurrentUser() => await _userManager.GetUserAsync(HttpContext.User);

        [HttpGet("[action]")]
        public IActionResult Register()
        {

            return View(new RegisterViewModel());

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            try
            {
                var isSuccess = await _uow.UserService.Register(model);
                if (isSuccess)
                    return View("ConfirmEmail");
                else
                    return View();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        [HttpGet("[action]")]
        public IActionResult ConfirmEmail()
        {

            return View();
        }

        [HttpPost("EmailVerification/{code}")]
        public JsonResult EmailVerification(int code)
        {

            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("[action]")]
        public IActionResult Login()
        {

            return View(new LoginViewModel());

        }

        [HttpPost("[action]")]
        public IActionResult Login(LoginViewModel model)
        {
            try
            {
              _uow.UserService.Login(model);
                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}