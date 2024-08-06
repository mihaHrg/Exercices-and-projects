using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingHomework.Ex_3
{
    public class AsyncService
    {
        public async Task<string> FetchDataAsync()
        {
            await Task.Delay(1000); // Simulate a delay
            return "Data fetched";
        }
    }
}

