using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_7
{
    public static class HotelManagerr
    {
        private static List<HotelRoom> rooms = new List<HotelRoom>();

        static HotelManagerr()
        {
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new StandardRoom(i));
            }
            for (int i = 11; i <= 15; i++)
            {
                rooms.Add(new DeluxeRoom(i));
            }
            for (int i = 16; i <= 20; i++)
            {
                rooms.Add(new Suite(i));
            }
        }
        public static void DisplayAvailableRooms()
        {
            Console.WriteLine("Available rooms:");
            foreach(var room in rooms)
            {
                Console.WriteLine($"Room number: {room.RoomNumber}, Type: {room.Type}, Price per night: {room.PricePerNight}");
            }
        }
        public static HotelRoom GetRoom(int roomNumber)
        {
            return rooms.Find(room => room.RoomNumber == roomNumber);
        }
    }
}
