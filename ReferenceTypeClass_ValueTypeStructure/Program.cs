using System;

namespace ReferenceTypeClass_ValueTypeStructure
{
    struct Employee
    {
        public int _Id;
        public int _salary;
    }
    class Teacher
    {
        public int _Id;
        public int _salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value type Struct example :");
            Employee a = new Employee();
            a._Id = 101;
            a._salary = 40000;
            Employee b = a;
            Employee c = a;
            a._salary = 50000;
            Console.WriteLine(a._Id);
            Console.WriteLine(a._salary);
            Console.WriteLine(b._Id);
            Console.WriteLine(b._salary);
            Console.WriteLine(c._Id);
            Console.WriteLine(c._salary);
            Console.WriteLine("Reference Type class example : ");
            Teacher p = new Teacher();
            p._Id = 200;
            p._salary = 60000;
            Teacher q = p;
            Teacher r = p;
            Console.WriteLine(p._Id);
            Console.WriteLine(p._salary);
            Console.WriteLine(q._Id);
            Console.WriteLine(q._salary);
            Console.WriteLine(r._Id);
            Console.WriteLine(r._salary);
        }
    }
}
