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
            bool a = true;
            bool b = false;
            Console.WriteLine(a ^ a); // False
            Console.WriteLine(a ^ b); // True
            Console.WriteLine(b ^ b); // False


            Console.ReadLine();
        }

     

    }


}
