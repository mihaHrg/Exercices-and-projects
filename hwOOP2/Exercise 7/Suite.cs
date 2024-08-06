using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_7
{
    public class Suite : HotelRoom
    {
        public Suite(int roomNumber)
        {
            RoomNumber = roomNumber;
            Type = RoomType.Suite;
            PricePerNight = 250;
        }
        public override double CalculateTotalPrice(int numberOfDays)
        {
            return PricePerNight * numberOfDays;
        }
    }
}
