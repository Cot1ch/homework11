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

        /// <summary>
        /// Использование предопределенного условного атрибута для условного выполнения кода. 
        /// В классе банковский счет добавить метод DumpToScreen, который отображает детали банковского счета.
        /// Для выполнения этого метода использовать условный атрибут, зависящий от символа условной компиляции DEBUG_ACCOUNT.
        /// Протестировать метод DumpToScreen.
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("Упражнение 14.1\n");

            BankAccount bankAccount = new BankAccount(123456, BankAccount.Account.Текущий);
            bankAccount.Put(40);

            bankAccount.DumpToScreen();
        }

        /// <summary>
        /// Упражнение 14.2 Создать пользовательский атрибут DeveloperInfoAttribute. 
        /// Этот атрибут позволяет хранить в метаданных класса имя разработчика и, дополнительно, дату разработки класса.
        /// Атрибут должен позволять многократное использование. 
        /// Использовать этот атрибут для записи имени разработчика класса рациональные числа
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("Упражнение 14.2\n");

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

        /// <summary>
        /// Домашнее задание 14.1. Создать пользовательский атрибут для класса из домашнего задания 13.1. 
        /// Атрибут позволяет хранить в метаданных класса имя разработчика и название организации. 
        /// Протестировать
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("\nДомашнее задание 14.1\n");

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
