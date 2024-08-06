using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_3
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public double Area { get;  set; }

        public abstract void CalculateArea();
        public virtual double GetPerimeter()
        {
            return 0;  //by default (without perimeter)
        }
       
       

    }
}
      

