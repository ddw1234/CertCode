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
            p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);
            p.Raise();


            Console.ReadLine();
        }

     

    }

    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }
    public class Pub
    {
        public event EventHandler<MyArgs> OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }

    //public void CreateAndRaise()
    //{
    //    Pub p = new Pub();
    //    p.OnChange += (sender, e)
    //    => Console.WriteLine("Event raised: { 0}”, e.Value");
    //    p.Raise();
    //}


}
