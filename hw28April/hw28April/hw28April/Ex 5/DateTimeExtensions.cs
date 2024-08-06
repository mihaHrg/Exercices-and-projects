using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw28April.Ex_5
{
    public static class DateTimeExtensions
    {
        public static string ToFullDateString(this DateTime dateTime)
        {
            return dateTime.ToString("MM/dd/yyyy  HH:mm:ss");
        }
    }
}
