using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AccountsApp.Model
{
    class Account
    {
        static private int _allUserTransactionCount = 0;
        private readonly int _accountNo;
        private int _balance;
        private readonly string _name;
        private int _userTransactionCount = 0;
        public Account(int acno, int bal, string name) {
            _accountNo = acno;
            _balance = bal;
            _name = name;
        }
        public void ShowDetails(Type a)
        {
            MethodInfo[] methods = a.GetMethods();
            Console.WriteLine("Total no of Methods : " + methods.Length);
            PropertyInfo[] properties = a.GetProperties();
            Console.WriteLine("Total no of Properties : " + properties.Length);
            ConstructorInfo[] constructors = a.GetConstructors();
            Console.WriteLine("Total no of Constructor : " + constructors.Length);
        }
        public void Deposit(int money)
        {
            _balance += money;
            _allUserTransactionCount++;
            _userTransactionCount++;
        }
        public void WithDrawal(int money)
        {
            if (_balance - money >= 500)
            {
                _userTransactionCount++;
                _allUserTransactionCount++;
                _balance -= money;
                Console.WriteLine("Withdrawal Successful ");
            }
            else
            {
                Console.WriteLine("Withdrawal Failed ");
            }
        }
        public int UserTransaction
        {
            get { return _userTransactionCount; }
        }
        static public int AllUserTransaction
        {
            get { return _allUserTransactionCount; }
        }
        public int Balance{ get { return _balance; }
        }
        public int AccountNo{ get { return _accountNo; }
        }
        public string Name{   get { return _name; }
        }
    }
}
