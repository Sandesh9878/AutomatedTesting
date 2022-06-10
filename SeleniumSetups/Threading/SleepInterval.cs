using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSetups.Threading
{
    public class SleepInterval
    {

        public static void ShortTime()
        {
            Thread.Sleep(2000);
        }
        public static void AverageTime()
        {
            Thread.Sleep(5000);
        }
        public static void LongTime()
        {
            Thread.Sleep(8000);
        }



    }
}
