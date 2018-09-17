using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertExam
{

    public static class Program
    {
        public static void Main()
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() => {
                Thread.Sleep(5);
                Console.WriteLine("1");
                Console.WriteLine(DateTime.Now.ToString());
                return 1;
            });

            tasks[1] = Task.Run(() => {
                Thread.Sleep(10);
                Console.WriteLine("2");
                Console.WriteLine(DateTime.Now.ToString());
                return 2;
            });

            tasks[2] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                Console.WriteLine(DateTime.Now.ToString());
                return 3;
            }
            );
            Task.WaitAll(tasks);

            Console.ReadLine();

        }
    }


}
