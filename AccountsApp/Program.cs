using AccountsApp.Model;
using System;

namespace AccountsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account shyam = new Account(129292, 1000, "Shyam");
            Type T = typeof(Account);
            shyam.ShowDetails(T);
        }
    }
}
