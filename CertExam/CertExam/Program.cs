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


        public static void Main()
        {
            ExceptionDispatchInfo possibleException = null;
            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }
            if (possibleException != null)
            {
                possibleException.Throw();
            }


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
