using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiliconAward.DataAccess.ViewModels.AspNetUser
{
    public class ContactUsViewModel
    {

       
        public int SubjectId { get; set; }
        public string Message { get; set; }
        public string CaptchaSitekey { get; set; }
    }
}
