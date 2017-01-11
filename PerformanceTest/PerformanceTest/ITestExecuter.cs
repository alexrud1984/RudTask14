using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
    interface ITestExecuter
    {
        bool MyQueueTest (string userSelection, int operAmount);
        bool NetQueueTest(int operAmount);
        bool MyStackTest(string userSelection, int operAmount);
        bool NetStackTest (int operAmount);
    }
}
