using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertExam
{

    public class Program
    {
        private static int counter;

        public static void Main()
        {
            Thread T1 = new Thread(PrintStar);
            
            T1.Name = "One";
            T1.Start();
            T1.Join();


            Thread T2 = new Thread(PrintPlus);

            T2.Name = "Two";
            T2.Start();
            T2.Join();
         



            Console.ReadLine();
        }

        static void PrintStar()
        {
            for (counter = 0; counter < 5; counter++)
            {
                Console.Write(" * " + "\t");
            }
        }

        private static void PrintPlus()
        {
            for (counter = 0; counter < 5; counter++)
            {
                Console.Write(" + " + "\t");
            }
        }


    }


}
