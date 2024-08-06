using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingHomework.Ex_4
{
    public class Operation
    {
        public int PerformOperation(int a, int b, string operation)
        {
            return operation switch
            {
                "add" => a + b,
                "subtract" => a - b,
                "multiply" => a * b,
                "divide" => b != 0 ? a / b : throw new DivideByZeroException(),
                _ => throw new ArgumentException("Invalid operation")
            };
        }
    }
}
