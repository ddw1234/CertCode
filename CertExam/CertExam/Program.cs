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
            Pub p = new Pub();
            //p.OnChange += () => Console.WriteLine("Event raised to method 1");
            //p.OnChange += () => Console.WriteLine("Event raised to method 2");

            p.OnChange += (null);
            p.Raise();

            //AB a = new AB();
            //a.CreateAndRaise();


            Console.ReadLine();
        }

     

    }

    public class Pub
    {
        public event Action OnChange = delegate { };
        public void Raise()
        {
            OnChange();
        }
    }

    public class AB
    {
        public void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
        }
    }


    //public class Pub
    //{
    //    public Action OnChange { get; set; }
    //    public void Raise()
    //    {
    //        //OnChange();
    //        if (OnChange != null)
    //        {
    //            OnChange();
    //        }
    //    }
    //}
    //public void CreateAndRaise()
    //{
    //    Pub p = new Pub();
    //    p.OnChange += () => Console.WriteLine("Event raised to method 1");
    //    p.OnChange += () => Console.WriteLine("Event raised to method 2");
    //    p.Raise();
    //}


}
