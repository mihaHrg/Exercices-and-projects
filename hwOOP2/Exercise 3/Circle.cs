using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_3
{
    
        public class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(string color, double radius)
            {
                Color = color;
                Radius = radius;
            }

            public override void CalculateArea()
            {
                Area = Math.PI * Math.Pow(Radius, 2);
            }

            public override double GetPerimeter()
            {
                return 2 * Math.PI * Radius;
            }

            public string GetPerimeter(string unit)
            {
                double perimeter = GetPerimeter();
                return $"Circumference: {perimeter} {unit}";
            }
        }
    }
