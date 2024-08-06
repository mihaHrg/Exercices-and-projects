using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_7
{
    public interface IBilling
    {
        void GenerateBill(int roomNumber, int numberOfDays);
    }
}
