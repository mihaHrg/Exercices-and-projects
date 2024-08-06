using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_7
{
    public abstract class HotelRoom
    {
        public int RoomNumber { get; set; }
        public RoomType Type { get; set; }
        public double PricePerNight {  get; set; }

        public abstract double CalculateTotalPrice(int numberOfDays);
    }
}
