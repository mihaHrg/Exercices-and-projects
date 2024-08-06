using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_7
{
    public class StandardRoom : HotelRoom
    {
        public StandardRoom(int roomNumber)
        {
            RoomNumber = roomNumber;
            Type = RoomType.Standard;
            PricePerNight = 150;
        }
        public override double CalculateTotalPrice(int numberOfDays)
        {
            return PricePerNight*numberOfDays;
        }
    }
}
