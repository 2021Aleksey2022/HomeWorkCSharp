using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Utilis;

namespace HomeWork4
{
    static class StaticClass
    {
        public static int[] arr;
        public static int number;
        public static int[] arr1;

        static void Main(string[] args)
        {
            RandomNumber(arr);
            SaveToFile(AppDomain.CurrentDomain.BaseDirectory + "ArrayNumber.txt");
            ArrayNumberList(AppDomain.CurrentDomain.BaseDirectory + "ArrayNumber.txt");
            Console.ReadLine();
        }
        #region[Ищем пары чисел, которые делятся на 3]
        public static void RandomNumber(int[] arr)
        {
            Outputhelpers.PrintInfo(4, "Щербаков Алексей Алксандрович");

            Console.WriteLine("Выводим случайные числа с диапазоном , проверяем, создовая пары чисел");
            Console.WriteLine("Нажмите Enter для продолжения......");
            Console.ReadLine();
            arr = new int[20];
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
            //int number;
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
        #endregion

        public static int[] ArrayNumberList(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            if (!File.Exists(fileName))
                throw new FileNotFoundException("Такого файла не существует");
            int n = int.Parse(streamReader.ReadLine());
            int[] arr1 = new int[n];


            for (int i = 0; i < n; i++)
            {
                if (!streamReader.EndOfStream)
                {
                    Console.WriteLine(arr1[i] = int.Parse(streamReader.ReadLine()));
                }

            }
            Console.WriteLine("---------------------------------------");
            Console.ReadLine();
            //streamReader.Close();
            return arr1;
        }
        public static int[] SaveToFile(string fileName)
        {
            arr1 = new int[20];
            Random random = new Random();
            StreamWriter streamWriter = new StreamWriter(fileName);
            streamWriter.WriteLine(arr1.Length);
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(-99, 100);
                Console.WriteLine($"{i} : {arr1[i]}");
            }
            for (int number = 0; number < arr1.Length; number++)
                streamWriter.WriteLine(arr1[number]);
            //StreamWriter streamWriter = new StreamWriter(fileName);
            //streamWriter.WriteLine(arr1.Length);
            //for (int i = 0; i < arr1.Length; i++)
            //    streamWriter.WriteLine(arr1[i]);
            streamWriter.Close();
            Console.WriteLine("---------------------------------------");
            Console.ReadLine();
            return arr1;
        }
    }
}
