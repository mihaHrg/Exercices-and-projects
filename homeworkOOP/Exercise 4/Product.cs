using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_4
{
    public  class Product
    {
        public string name;
        public double price;
        public int quantity;
        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public string GetName()
        {
            return name;
        }
        public double GetPrice()
        {
            return price;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetName()
        {
            this.name = name;
        }
        public void SetPrice()
        {
            this.price = price;
        }
        public void SetQuantity()
        {
            this.quantity = quantity;
        }
    }
}
