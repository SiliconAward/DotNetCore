using Microsoft.AspNetCore.Identity;
using NToastNotify;
using SiliconAward.DataAccess.Entities.Identities;
using SiliconAward.DataAccess.StaticLists;
using SiliconAward.DataAccess.ViewModels.AspNetUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SiliconAward.Service.UserServices
{
    public class UserService : IUserService
    {
        private readonly UserManager<AspNetUsers> _userManager;
        private readonly IToastNotification _toastNotification;

        public UserService(UserManager<AspNetUsers> userManager, IToastNotification toastNotification)
        {
            _userManager = userManager;
            _toastNotification = toastNotification;
        }

        public int Login(LoginViewModel model)
        {
            return 0;
        }

        public async Task<bool> Register(RegisterViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                _toastNotification.AddWarningToastMessage("Already exist user with this email");
                return false;
            }
            #region validation
            bool emailisValid = EmailIsValid(model.Email);
            bool passwordIsStrong = PasswordIsStrong(model.Password);
            //bool userNameisValid = UserNameisValid(model.UserName);
             if (!passwordIsStrong)
            {
                _toastNotification.AddWarningToastMessage("password must have upper ,lower ,special and digit character.also more than 8 chars");
                return false;
            }   if (!emailisValid)
            {
                _toastNotification.AddWarningToastMessage("Invalid email");
                return false;
            }
        
            #endregion

            var newUser = new AspNetUsers()
            {
                Email = model.Email,
                PasswordHash = model.Password,
                UserName = model.UserName
            };
            var crateResult = await _userManager.CreateAsync(newUser, model.Password);
            if (crateResult.Succeeded)
            {
                var addRoleResult = await _userManager.AddToRoleAsync(newUser, UserRoles.Participant);
                if (addRoleResult.Succeeded)
                {
                    await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                    _toastNotification.AddSuccessToastMessage("We sent an email. please confirm your email");
                    return true;
                }
                else
                {
                    _toastNotification.AddWarningToastMessage("problem in registering.please report to admin!");
                    return false;
                }
            }
            _toastNotification.AddWarningToastMessage("problem in registering.please try again!");
            return false;
        }



        /// <summary>
        /// validation email
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns></returns>
        public bool EmailIsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// check for password is strong
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool PasswordIsStrong(string password)
        {
            HashSet<char> specialCharacters = new HashSet<char>() { '%', '$', '#', '!', '@', '*', '&' };
            if (password.Any(char.IsLower) && //Lower case 
                 password.Any(char.IsUpper) &&
                 password.Any(char.IsDigit) &&
                 password.Any(specialCharacters.Contains) &&
                 password.Length >= 8)
            {
                //valid password
                return true;
            }
            return false;
        }

        /// <summary>
        /// validation username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool UserNameisValid(string username)
        {
            username = "aA1%";
            HashSet<char> specialCharacters = new HashSet<char>() { '%', '$', '#', '!', '@', '*', '&' };
            if (!username.Any(specialCharacters.Contains) &&
                 username.Length >= 8)
            {
                //valid password
                return true;
            }
            return false;
        }
    }
}
