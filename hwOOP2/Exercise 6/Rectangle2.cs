using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_6
{
    public class Rectangle2 : Ishape, Icolor
    {
        private double width;
        private double height;
        private string color;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Rectangle2(double width, double height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }
        public double CalculateArea()
        {
            return width * height;
        }
        public string CalculateArea(string unit)
        {
            double area = CalculateArea();
            return $"Area: {area} {unit}";
        }
    }
}
