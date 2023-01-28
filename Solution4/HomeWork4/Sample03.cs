using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Utilis;
using ClassArray;

namespace HomeWork4
{
    class Sample03
    {
        private int[] a;
        private int sum;
        private int num;

       
        #region Свойство, возвращающее сумму всех элеметов массива
        public int Sum
        {           
            get 
            {                
                return sum; 
            }
        }
        #endregion
        
      

        #region Конструктор, массива от начального значения с заданным шагом
        public Sample03(int n, int start, short step)
        {
            Console.WriteLine("Выводим массив с заданным шагом");
            Console.WriteLine("Нажмите Enter для продолжения....");
            Console.WriteLine("----------------------------------");
            Console.ReadLine();
            a = new int[20];
            Random random = new Random();
           
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(-99, 100);
                a[i] = start;
                start += step;
                Console.WriteLine($"{i} : {a[i]}");
            }
            Console.WriteLine();
            Console.ReadLine();           
        }
        #endregion
        static void Main(string[] args)
        {            
            Sample03 sample03 = new Sample03(20, 1, 2);
            sample03.SumNumber(0);
            sample03.Inverse();
            sample03.Multi(2);           
        }
        #region Сумма всех элеметов массива
        public int SumNumber(int sum)
        {
            Console.WriteLine("Метод возвращающий сумму всех элементов массива");
            Console.WriteLine("Нажмите Enter для продолжения....");
            Console.WriteLine("----------------------------------");
            Console.ReadLine();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                
                sum += a[i];

            }
            Console.WriteLine($"{sum}");
            Console.WriteLine();
            Console.ReadLine();
            return sum;
        }
        #endregion

        #region Меняем знаки всех элементов масива
        public void Inverse()
        {
            Console.WriteLine("Метод меняющий знак всех элементов массива");
            Console.WriteLine("Нажмите Enter для продолжения....");
            Console.WriteLine("----------------------------------");
            Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = -a[i];
                Console.WriteLine($"{a[i]}");
            }
            Console.ReadLine();
        }
        #endregion

        #region Метод умножающий каждый элемент массива
        public void Multi(int n)
        {
            Console.WriteLine("Метод умножающий  все элементы массива, на заданное число");
            Console.WriteLine("Нажмите Enter для продолжения....");
            Console.WriteLine("----------------------------------");
            Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= n;
                Console.Write($"{a[i]}\t");
                
            }
            Console.ReadLine();
        }
        #endregion
        
        
    }
}
