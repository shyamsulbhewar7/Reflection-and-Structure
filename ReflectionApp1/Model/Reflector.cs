using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionApp1.Model
{
    public class Reflector
    {
        public void ShowDetails(Reflector obj)
        {
            Type a = obj.GetType();
            MethodInfo[] methods = a.GetMethods();
            Console.WriteLine("Total no of methods : " + methods.Length);
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            PropertyInfo[] properties = a.GetProperties();
            Console.WriteLine("\n\nTotal no of properties : " + properties.Length);
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            ConstructorInfo[] constructors = a.GetConstructors();
            Console.WriteLine("\n\nTotal nof of constructor : " + constructors.Length);
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
