using System;

namespace Reflection_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Reflection is the process of describing the metadata of types, 
             methods and fields in a code. The namespace System.Reflection 
             enables you to obtain data about the loaded assemblies, the elements 
             within them like classes, methods and value types.
            */

            Type a = typeof(string);
            // Use Reflection to find about
            // any sort of data related to t
            Console.WriteLine("Name : {0}", a.Name);
            Console.WriteLine("Full Name : {0}", a.FullName);
            Console.WriteLine("Namespace : {0}", a.Namespace);
            Console.WriteLine("Base Type : {0}", a.BaseType);

            Type b = typeof(int);
            Console.WriteLine("\n\nName : {0}", b.Name);
            Console.WriteLine("Full Name : {0}", b.FullName);
            Console.WriteLine("Namespace : {0}", b.Namespace);
            Console.WriteLine("Base Type : {0}", b.BaseType);

        }
    }
}
