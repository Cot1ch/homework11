#define DEBUG_ACCOUNT

using System;


namespace Tumakov14
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();

            Console.WriteLine("alt+f4 для выхода...");
            Console.ReadKey();
        }

        static void Task1()
        {
            BankAccount bankAccount = new BankAccount(123456, BankAccount.Account.Текущий);
            bankAccount.Put(40);

            bankAccount.DumpToScreen();
        }
        static void Task2()
        {
            var attrs = typeof(Ratio).GetCustomAttributes(true);

            foreach (var attr in attrs)
            {
                DeveloperInfoAttribute att = attr as DeveloperInfoAttribute;
                if (att != null)
                {
                    Console.WriteLine($"Кто: {att._DevName}\nКогда: {att._Date}");
                }
            }
            
        }
        static void Task3()
        {
            var attrs = typeof(Building).GetCustomAttributes(true);

            foreach (var attr in attrs)
            {
                DevAndOrgInfoAttribute att = attr as DevAndOrgInfoAttribute;
                if (att != null)
                {
                    Console.WriteLine($"Кто: {att.DevName}\nОткуда: {att.DevOrg}");
                }
            }
        }
    }
}
