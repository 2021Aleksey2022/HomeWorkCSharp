using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;

namespace HomeWork4
{
    internal class Sample01
    {
        static void Main(string[] args)
        {
            RandomNumber();
        }
        public static void RandomNumber()
        {
            Outputhelpers.PrintInfo(4, "Щербаков Алексей Алксандрович");

            Console.WriteLine("Выводим случайные числа с диапазоном , проверяем, создовая пары чисел");
            Console.WriteLine("Нажмите Enter для продолжения......");
            Console.ReadLine();
            int[] arr = new int[20];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10000, 10000);
                Console.WriteLine($"{i} : {arr[i]}");
            }
            Console.WriteLine("Ищем пары чисел, которые делятся на 3, но из пары должно делиться только одно число");
            Console.WriteLine("Нажмите Enter для вывода результата......");
            Console.ReadLine();
            int count = 0;
            int number;
            for (number = 0; number < arr.Length - 1; number++)
            {
                if (arr[number] % 3 == 0 && arr[number + 1] % 3 != 0 || arr[number + 1] % 3 == 0 && arr[number] % 3 != 0)
                {
                    count++;
                    Console.WriteLine("****************************************************");
                    Console.WriteLine("Подходящая по условию пара чисел: {0} и {1} ", arr[number], arr[number + 1]);
                    Console.WriteLine("----------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Эта пара не подходит: {0} и {1}", arr[number], arr[number + 1]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("всего количество пар делящихся на 3 : " + count);
            Console.WriteLine("Нажмите любую клавишу для выхода:..");
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
