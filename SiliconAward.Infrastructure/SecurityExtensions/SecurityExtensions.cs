using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SiliconAward.Infrastructure.SecurityExtensions
{
    public class SecurityExtensions
    {
        public static async Task<T> ValidateRecaptcha<T>( HttpRequest request,  string secretKey) 
        {
            var response = request.Form["g-recaptcha-response"];
            var client = new HttpClient();
            string result = await client.GetStringAsync(
                string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}",
                    secretKey,
                    response)
                    );

            var captchaResponse = JsonConvert.DeserializeObject<T>(result);

            return captchaResponse;
        }
      

    }
}
