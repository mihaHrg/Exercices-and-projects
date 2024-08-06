using hwOOP2.Exercise_3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_6
{
    public class Circle2 : Ishape, Icolor
    {
        private double radius;
        private string color;

        public Circle2(double radius)
        {
            this.radius = radius;
            color = "Black";
        }

        public Circle2(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public string CalculateArea(string unit)
        {
            double area = CalculateArea();
            return $"Area: {area} {unit}";
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
