using System;


namespace Tumakov13
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();

            Console.WriteLine("Нажмите alt+f4 для выхода...");
            Console.ReadKey();
        }

        /// <summary>
        /// Из класса банковский счет удалить методы, возвращающие значения полей номер счета и тип счета, 
        /// заменить эти методы на свойства только для чтения.
        /// Добавить свойство для чтения и записи типа string для отображения поля держатель банковского счета.
        /// Изменить класс BankTransaction, созданный для хранений финансовых операций со счетом - заменить методы доступа к данным на свойства для чтения
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("Упражнение 13.1\n");

            BankAccount ba1 = new BankAccount("Василий", 12345678m, BankAccount.Account.Сберегательный);
            ba1.Name = "Кирилл";
            BankAccount ba2 = new BankAccount("Петр", 87654321m, BankAccount.Account.Текущий);

            if (ba1.MoneyTransfer(ba2, 60000))
            {
                Console.WriteLine("Операция прошла успешно\n");
            }
            else
            {
                Console.WriteLine("!! Проверьте сумму !!\n");
            }

            if (ba2.MoneyTransfer(ba1, 654321))
            {
                Console.WriteLine("Операция прошла успешно\n");
            }
            else
            {
                Console.WriteLine("!! Проверьте сумму !!\n");
            }

            Console.WriteLine($"\n1 счёт: {ba1.Name}\n{ba1.Id}\n{ba1.Acc} {ba1.Balance}");

            Console.WriteLine("\nОперации:");
            foreach (var bt in ba1.Queue)
            { 
                Console.WriteLine(bt.Time + " | " + bt.Amount);
            }

            Console.WriteLine($"\n2 счёт: {ba2.Name}\n{ba2.Id}\n{ba2.Acc} {ba2.Balance}");

            Console.WriteLine("\nОперации:");
            foreach (var bt in ba2.Queue)
            {
                Console.WriteLine(bt.Time + " | " + bt.Amount);
            }
        }

        /// <summary>
        /// Добавить индексатор в класс банковский счет для получения доступа к любому объекту BankTransaction.
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("\nУпражнение 13.2\n");

            BankAccount2 ba1 = new BankAccount2(12345678m, BankAccount2.Account.Сберегательный);
            BankAccount2 ba2 = new BankAccount2(87654321m, BankAccount2.Account.Текущий);

            if (ba1.MoneyTransfer(ba2, 60000))
            {
                Console.WriteLine("Операция прошла успешно\n");
            }
            else
            {
                Console.WriteLine("!! Проверьте сумму !!\n");
            }

            if (ba1.MoneyTransfer(ba2, -120000))
            {
                Console.WriteLine("Операция прошла успешно\n");
            }
            else
            {
                Console.WriteLine("!! Проверьте сумму !!\n");
            }

            if (ba2.MoneyTransfer(ba1, 654321))
            {
                Console.WriteLine("Операция прошла успешно\n");
            }
            else
            {
                Console.WriteLine("!! Проверьте сумму !!\n");
            }

            Console.WriteLine($"{ba1.Id} | Баланс: {ba1.Balance}\n");

            Console.WriteLine(ba1[0]);
            Console.WriteLine(ba1[1]);

            Console.WriteLine($"{ba2.Id} | Баланс: {ba2.Balance}\n");

            Console.WriteLine(ba2[1]);
            ba2[1] = new BankTransaction2(-123654);
            Console.WriteLine(ba2[1]);
        }

        /// <summary>
        /// В классе здания из домашнего задания 7.1 все методы для заполнения и получения значений полей заменить на свойства
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("\nДомашнее задание 13.1\n");

            Building building = new Building(123, 41, 164, 1);
            
            Console.WriteLine("Номер: " + building.PersNumber);
            Console.WriteLine("Высота: " + building.height);
            Console.WriteLine("Этажи: " + building.countFloors);
            Console.WriteLine("Квартиры: " + building.countFlat);
            Console.WriteLine("Подъезды: " + building.countEntrance);

        }

        /// <summary>
        /// Создать класс для нескольких зданий. Поле класса – массив на 10 зданий.
        /// В классе создать индексатор, возвращающий здание по его номеру
        /// </summary>
        static void Task4()
        {
            Console.WriteLine("\nДомашнее задание 13.2\n");

            BuildList buildList = new BuildList();

            Building2 building1 = new Building2(123, 41, 164, 1);
            Building2 building2 = new Building2(120, 40, 240, 2);
            Building2 building3 = new Building2(90, 30, 270, 3);
            Building2 building4 = new Building2(60, 20, 120, 2);
            Building2 building5 = new Building2(48, 16, 128, 8);

            buildList[0] = building1;
            buildList[2] = building5;
            buildList[1] = building4;
            buildList[4] = building3;
            buildList[9] = building2;


            for (int i = 0; i < 10; i++)
            {
                if (buildList[i] != null)
                {
                    Console.WriteLine(buildList[i]);
                }
            }
        }
    }
}
