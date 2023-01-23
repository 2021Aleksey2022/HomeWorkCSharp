using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;

namespace HomeWork2
{
    /// <summary>
    /// Вычисление индекса массы тела
    /// </summary>
    internal class Sample05
    {
        static void Main(string[] args)
        {
            WightHuman();
        }
        public static void WightHuman()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("5 задание. Вычисление индекса массы тела.");          
            Outputhelpers.PrintInfo(2, "Щербаков Алексей Алескандрович");

            int weight;
            double metre, height, temp;


            Console.Write("\nВведите свой вес, округлив его до целого числа: ");
            String z = Console.ReadLine();
            weight = int.Parse(z);



            Console.Write("Какой ваш рост ?: ");
            String g = Console.ReadLine();
            metre = double.Parse(g);

            height = metre / 100;

            double res01 = SumNumbers(weight, height);
            Console.WriteLine($"Ваш вес : {weight} килограмм, Ваш рост : {height} метра  ");

            res01 = weight / (height * height);
            if (res01 < 18.5)
            {
                temp = 18.5 * (height * height);
                Console.WriteLine(temp);
                Console.WriteLine($"\nВаш ИМТ {res01:#.##}, что означает дефицит веса. Норма с 18.5 до 25.\nДо нижнего порога нормы, вам необходимо набрать {temp - weight:#.##} кг");
                Console.WriteLine("Нажмите любую клавищу для выхода...");
                Console.ReadKey();
            }
            else if (res01 > 25)
            {
                temp = 25 * (height * height);
                Console.WriteLine(temp);
                Console.WriteLine($"\nВаш ИМТ {res01:#.##}, что означает избыток веса. Норма с 18.5 до 25. \nДо верхнего порога нормы,вам необходимо сбросить {weight - temp:#.##} кг.");
                Console.WriteLine("Нажмите любую клавищу для выхода...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\nДа, нормальный у вас вес. Ваш ИМТ {res01:#.##}.");
                Console.WriteLine("Нажмите любую клавищу для выхода...");
                Console.ReadKey();
            }
        }


        static double SumNumbers(double a, double b)
        {
            double res = a / (b * b);
            return res;

        }
    }
}
    
    

