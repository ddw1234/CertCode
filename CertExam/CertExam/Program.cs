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

        public struct Point
        {
            public int x, y;
            public Point(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
        public static void Main()
        {
            Point p = new Point(5,7);
            

            Console.WriteLine(p.x.ToString(), p.y);

            

       

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
