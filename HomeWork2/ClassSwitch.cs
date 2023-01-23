using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;

namespace HomeWork2
{
    public static class ClassSwitch 
    {
        public static void OperatorSwitch()
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("Мои Задачи: ");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача №1 ");
                Console.WriteLine("2 -> Задача №2 ");
                Console.WriteLine("3 -> Задача №3 ");
                Console.WriteLine("4 -> Задача №4 ");
                Console.WriteLine("5 -> Задача №5 ");
                Console.WriteLine("0 -> Завершение работы преложения");
                Console.WriteLine("=================================\n");
                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Tasck1();
                        break;
                    case 2:
                        Tasck2();
                        break;
                    case 3:
                        Tasck3();
                        break;
                    case 4:
                        Tasck4(); 
                        break;
                    case 5:
                        Tasck5();
                        break;
                    case 0:
                        Console.WriteLine("Завершение работы преложения");
                        Console.WriteLine("Нажмите на любкю клавишу....");
                        Console.ReadKey();
                        f = false;
                        break;
                    default:
                        Console.WriteLine("Вы вели некоректно номер задачи, пожалуйста повторите попытку ");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public static void Tasck1()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №1... ");
            Console.WriteLine("========================");
            Console.BackgroundColor = ConsoleColor.Red;
            Outputhelpers.PrintInfo(2, "Щербаков Алексей Александрович");
            Console.WriteLine("Метод, возвращающий минимальное из трёх чисел: ");
            Console.WriteLine("===============================================");
            Console.WriteLine("Нажмите Enter для продолжения....");
            Console.ReadLine();
            Sample01.NumberMin();

        }
        public static void Tasck2()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №2... ");
            Console.WriteLine("========================");
            Console.BackgroundColor = ConsoleColor.Red;
            Outputhelpers.PrintInfo(2, "Щербаков Алексей Алескандрович");
            Console.WriteLine("Метод подсчета количество цифр числа: ");
            Console.WriteLine("===============================================");
            Console.WriteLine("Нажмите Enter для продолжения....");
            Console.ReadLine();
            Sample02.SumNunbers();
        }
        public static void Tasck3()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №3... ");
            Console.WriteLine("========================");
            Console.BackgroundColor = ConsoleColor.Red;
            Outputhelpers.PrintInfo(2, "Щербаков Алексей Александолвич");
            Console.WriteLine("Вводите числа, пока не будет введён ноль для подсчёта нечетных положительных чисел: ");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Сумма нечетных положительных чисел: {0}", Sample03.SumOdd(0));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода....");
            Console.ReadKey();
        }
        public static void Tasck4()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №4... ");
            Console.WriteLine("========================");
            Console.BackgroundColor = ConsoleColor.Red;
            Outputhelpers.PrintInfo(2, "Щербаков Алексей Алескандрович");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Проверка логина и пароля ");
            Console.WriteLine("-------------------------");
            Sample04.LoginPassword();
        }
        public static void Tasck5()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №5... ");
            Console.WriteLine("========================");
            Sample05.WightHuman();
        }
    }
}

