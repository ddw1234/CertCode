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
            object lockA = new object();
            object lockB = new object();
            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Console.WriteLine("1");
                    Console.WriteLine(DateTime.Now);
                    Thread.Sleep(1000);
                    Console.WriteLine(DateTime.Now);
                    lock (lockB)
                    {
                        Console.WriteLine("Lockedde A and B");
                    }
                }
            });

            

            lock (lockB)
            {
                Console.WriteLine("2");
                Console.WriteLine(DateTime.Now);
               
                Console.WriteLine(DateTime.Now);
                lock (lockA)
                {
                    Console.WriteLine("Locked A and B");
                }
            }
            up.Wait();



            Console.ReadLine();
        }

        


    }


}
