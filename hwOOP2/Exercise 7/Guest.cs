using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_7
{
    public class Guest : IHotelService, IBilling
    {
        private string name;
        private string phoneNumber;
        
        public Guest(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public void BookRoom(int roomNumber)
        {
            Console.WriteLine($"{name} booked room: {roomNumber}");
        }
        public void CheckOut (int roomNumber)
        {
            Console.WriteLine($"{name} checked out of room: {roomNumber}");
        }
        public void GenerateBill(int roomNumber, int numberOfDays)
        {
            HotelRoom room = HotelManagerr.GetRoom(roomNumber);
            if (room != null )
            {
                double totalPrice = room.CalculateTotalPrice(numberOfDays);
                Console.WriteLine($"Ion for {name}: Room {roomNumber}, Total amount: {totalPrice} lei");
            }
            else
            {
                Console.WriteLine($"Room {roomNumber} not found.");
            }
        }
    }
}
