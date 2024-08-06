using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_1
{
    public class Transaction
    {
        public DateTime Timestamp { get; private set; }
        public string Type { get; private set; }
        public decimal Amount { get; private set; }

        public Transaction (DateTime timestamp, string type, decimal amount)
        {
            Timestamp = timestamp;
            Type = type;
            Amount = amount;
        }
    }
}
