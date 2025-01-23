using System;


namespace Tumakov13
{
    internal class Program
    {
        static void Main()
        {
            // Дописать нумерацию тасков
            //Task1(); // Дописать держателя счета 
            //Task2();
            //Task3();
            //Task4();

            Console.WriteLine("Нажмите alt+f4 для выхода...");
            Console.ReadKey();
        }
        static void Task1()
        {
            BankAccount ba1 = new BankAccount(12345678m, BankAccount.Account.Сберегательный);
            BankAccount ba2 = new BankAccount(87654321m, BankAccount.Account.Текущий);

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

            Console.WriteLine("1 счёт: " + ba1.Id + " " + ba1.Acc + " " + ba1.Balance);

            Console.WriteLine("Операции:");
            foreach (var bt in ba1.Queue)
            { 
                Console.WriteLine(bt.Time + " | " + bt.Amount);
            }

            Console.WriteLine("\n2 счёт: " + ba2.Id + " " + ba2.Acc + " " + ba2.Balance);

            Console.WriteLine("Операции:");
            foreach (var bt in ba2.Queue)
            {
                Console.WriteLine(bt.Time + " | " + bt.Amount);
            }
        }
        static void Task2()
        {
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
        static void Task3()
        {
            Building building = new Building(123, 41, 164, 1);
            
            Console.WriteLine(building.PersNumber);
            Console.WriteLine(building.height);
            Console.WriteLine(building.countFloors);
            Console.WriteLine(building.countFlat);
            Console.WriteLine(building.countEntrance);

        }
        static void Task4()
        {
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
