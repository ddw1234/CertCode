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
       

        public static void Main()
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };


            calc(3, 4);


            Console.ReadLine();
        }

     

    }


}
