using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_7
{
    public class DeluxeRoom : HotelRoom
    {
        public DeluxeRoom(int roomNumber)
        {
            RoomNumber = roomNumber;
            Type = RoomType.Deluxe;
            PricePerNight = 200;
        }
        public override double CalculateTotalPrice(int numberOfDays)
        {
            return PricePerNight * numberOfDays;
        }
    }
}
