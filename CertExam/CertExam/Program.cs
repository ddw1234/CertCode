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

    class Base
    {
        public void Execute() { Console.WriteLine("Base.Execute"); }
    }
    class Derived : Base
    {
        public new void Execute() { Console.WriteLine("Derived.Execute"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Execute();
            b = new Derived();
            b.Execute();
            

            Derived d = new Derived();
            d.Execute();
            
            
           

            Console.ReadLine();
        }

        
    }





}
