using System;
using System.Collections.Generic;
using System.Text;

namespace SiliconAward.DataAccess.ViewModels.AspNetUser
{
    public class RecaptchaResponseModel
    {
        public bool Success { get; set; }
        public DateTime? Challenge_ts { get; set; }
        public string Hostname { get; set; }
    }
}
