﻿using System;
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

            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);

            int val = intGenericClass.genericMethod(200);

            intGenericClass.genericProperty = 24;

            

            int kt = intGenericClass.genericProperty;
            Console.WriteLine(kt);

            Console.ReadLine();
        }

        

    }

    class MyGenericClass<T>
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }



}
