using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw28April.Ex_2
{
    public class BlankNameException : Exception
    {
        public BlankNameException(string message) : base(message)
        {

        }

    }
}
