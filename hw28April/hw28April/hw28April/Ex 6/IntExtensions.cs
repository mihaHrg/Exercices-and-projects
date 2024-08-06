using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw28April.Ex_6
{
    public static class IntExtensions
    {
        public static string ToBinary(this int number)
        {
            return Convert.ToString(number,2);
        }
    }
}
