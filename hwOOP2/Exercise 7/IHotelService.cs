using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_7
{
    public interface IHotelService
    {
        void BookRoom(int roomNumber);
        void CheckOut(int roomNumber);
    }
}
