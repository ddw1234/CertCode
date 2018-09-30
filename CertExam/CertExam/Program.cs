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
            object _lock = new object();
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                    lock (_lock)
                        n++;
                Console.WriteLine(n);
            });

            Console.WriteLine( up.Id.ToString());
            for (int i = 0; i < 100; i++)

                lock (_lock)
                    n--;
            Console.WriteLine(n);

            Console.WriteLine(up.Id.ToString());
            up.Wait();
            Console.WriteLine(n);

            Console.ReadLine();
        }

        


    }


}
