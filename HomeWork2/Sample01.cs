using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;
using HomeWork2;

namespace HomeWork2
{

    
    public  class Sample01
    {
        /// <summary>
        ///Метод, возвращающий минимальное из трёх чисел 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.Red;
            Outputhelpers.PrintInfo(2, "Щербаков Алексей Александрович");            
            Console.WriteLine("Метод, возвращающий минимальное из трёх чисел: ");
            Console.WriteLine("===============================================");
            Console.WriteLine("Нажмите Enter для продолжения....");
            Console.ReadLine();           
            NumberMin();
            
        }
        public static int NumberMin()
        {
            int number;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            number = a <= b && a <= c ? a : (b <= a && b <= c ? b : c);
            Console.WriteLine($"Минимальное число: {number}");
            Console.WriteLine("Нажмите любую клавишу для выхода....");
            Console.ReadKey();
            return number;
        }
    }
}
