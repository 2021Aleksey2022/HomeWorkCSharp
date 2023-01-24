using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;
namespace HomeWork_3
{
    internal class Sample01
    {
        #region[Структура, поля, конструкторы]
        struct Complex
        {
            public double re;
            public double im;
            public static Complex Plus(Complex a, Complex b)
            {
                Complex complexres;
                complexres.re = a.re + b.re;
                complexres.im = a.im + b.im;
                return complexres;
            }
            public static Complex Minus(Complex a, Complex b)
            {
                Complex complexres;
                complexres.re = a.re - b.re;
                complexres.im = a.im - b.im;
                return complexres;
            }
            public override string ToString()
            {
                return $"{re} + {im}i";
            }
        }
        #endregion
        static void Main(string[] args)
        {
            ComplexNumber();
        }
        #region[Сложение, Вычитание кмплексного числа]
        public static void ComplexNumber()
        {
            Outputhelpers.PrintInfo(3, "Щербаков Алескй Александрович");
            Console.WriteLine("Сложение, Вычитание комплексного числа");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Нажмите Enter для продолжения......");
            Console.ReadLine();
            Complex complex1;
            Console.Write("Введите первое комплексное  число: ");
            complex1.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного число: ");
            complex1.im = double.Parse(Console.ReadLine());

            Complex complex2;
            Console.Write("Введите второе комплексное  число: ");
            complex2.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного число: ");
            complex2.im = double.Parse(Console.ReadLine());


            Complex complex4 = Complex.Plus(complex1, complex2);
            Complex complex5 = Complex.Minus(complex1, complex2);

            Console.WriteLine("Складываем, нажмите Enter для получения результата");
            Console.ReadLine();
            Console.WriteLine($"Результат сложения комплексных чмсел: {complex1} и {complex2} = {complex4}");
            Console.WriteLine("Нажмите Enter для продолжения......");
            Console.ReadLine();
            Console.WriteLine("Вычитаем, нажмите Enter для получения результата");
            Console.ReadLine();
            Console.WriteLine($"Результат вычитания комплексных чмсел: {complex1} и {complex2} = {complex5}");
            Console.WriteLine("Нажмите на любую клавишу для выхода из приложения...");
            Console.ReadKey();
        }
        #endregion
    }
}
