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
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                    Interlocked.Increment(ref n);
            });
            for (int i = 0; i < 100; i++)
                Interlocked.Decrement(ref n);
            up.Wait();
            Console.WriteLine(n);



            Console.ReadLine();
        }

        


    }


}
