using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SiliconAward.Common.Tools.Extenstions
{
   public static class DateTimeExtensions
    {
        public static string GetPersianDate(DateTime d)
        {
            PersianCalendar pc = new PersianCalendar();
            var persianDate = string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
            return persianDate;
        }

    }
}
