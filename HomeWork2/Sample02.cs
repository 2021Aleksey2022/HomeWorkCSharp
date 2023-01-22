using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;
using HomeWork2;

namespace HomeWork2
{
    public static class Sample02
    {
        public static int x;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Outputhelpers.PrintInfo(2, "Щербаков Алексей Алескандрович");
            Console.WriteLine("Метод подсчета количество цифр числа: ");
            Console.WriteLine("===============================================");
            Console.WriteLine("Нажмите Enter для продолжения....");
            Console.ReadLine();
            SumNunbers();
        }
        public static void SumNunbers()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================================");
            Console.WriteLine($"Вы ввели число: {x} ");
            Console.WriteLine("Нажите Enter для продолжения, распечатываем количество цифр числа: ");
            Console.ReadLine();
            Console.WriteLine("Результат: ");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"{i}\t");
            }
            Console.WriteLine("Нажмите любую клавишу для выхода.....");
            Console.ReadKey();
        }


    }
}

