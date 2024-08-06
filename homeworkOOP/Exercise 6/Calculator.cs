using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_6
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Substract (int x, int y)
        {
            return (x - y);
        }
        public int Multiply (int x, int y)
        {
            return x * y;
        }
        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Cannot divide by zero");
            }
            return x / y;
        }
        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }
        public double SquareRoot(double x)
        {
            if (x<0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number");
            }
            return Math.Sqrt(x);
        }
    }
}
