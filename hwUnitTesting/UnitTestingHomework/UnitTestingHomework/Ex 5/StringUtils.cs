using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingHomework.Ex_5
{
    public class StringUtils
    {
        public string ReverseString(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return new string(input.Reverse().ToArray());
        }
    }
}
