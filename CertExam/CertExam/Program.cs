using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertExam
{

    public class Program
    {

        [Flags]
        enum Days
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8,
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40
        }
        public static void Main()
        {
           
        //Days readingDays = Days.Monday | Days.Saturday | Days.Friday | Days.Sunday | Days.Tuesday | Days.Wednesday;

       Days readingDays = Days.Monday | Days.Sunday;

            Console.WriteLine(readingDays);

        Console.ReadLine();
        }

        private static int ReadAndParse()
        {
            string s = Console.ReadLine();
            int i = int.Parse(s);
            return i;
        }



    }



}
