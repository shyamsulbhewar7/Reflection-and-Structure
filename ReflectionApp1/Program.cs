using ReflectionApp1.Model;
using System;

namespace ReflectionApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector reflector = new Reflector();
            reflector.ShowDetails(reflector);
        }
    }
}
