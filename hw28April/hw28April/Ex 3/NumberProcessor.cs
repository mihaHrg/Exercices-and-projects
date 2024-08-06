using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hw28April.Ex_3
{
    public class NumberProcessor
    {
        public List<int> Numbers {  get; private set; }
        public NumberProcessor()
        {
            Numbers = new List<int>();
        }
        public void ReadNumbers()
        {
            Console.WriteLine("Enter numbers (type 'done' to finish):");
            while (true) 
            { 
                string input =Console.ReadLine();
                if (input.ToLower()=="done")
                {
                    break;
                }
                if (!int.TryParse(input, out int number))
                {
                    throw new FormatException();
                }

                Numbers.Add(number);
            }
            if (Numbers.Count == 0)
            {
                throw new DivideByZeroException();
            }
        }
        public void CalculateSumAndAverage()
        {
            long sum = 0;
            foreach (int num in Numbers)
            {
                if (sum + num>int.MaxValue)
                {
                    throw new OverflowException();
                }
                sum += num;
            }
            double average = (double)sum / Numbers.Count;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
