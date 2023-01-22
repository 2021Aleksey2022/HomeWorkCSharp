using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;
using HomeWork2;

namespace HomeWork2
{
    public static class Sample03
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Outputhelpers.PrintInfo(2, "Щербаков Алексей Александолвич");
            Console.WriteLine("Вводите числа, пока не будет введён ноль для подсчёта нечетных положительных чисел: ");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Сумма нечетных положительных чисел: {0}", SumOdd(0));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода....");
            Console.ReadKey();
        }
        public static int SumOdd(int sum)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {number}");
            if(number == 0)
            {
                Console.WriteLine("Считаем....");
                Console.WriteLine("Нажмите Enter для получения результата: ");
                Console.ReadLine();
                return sum;
            }
            if(number > 0 && number % 2 == 1)            
                return SumOdd(number + sum);
            return SumOdd(sum);
        }
    }
}
