using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;

namespace HomeWork_3
{
    #region[Поля и их свойства]
    internal class ComplexClass
    {
        private double re;
        private double im;
        public double Re
        {
            get { return re; }
            set { re = value; }
        }
        public double Im
        {
            get { return im; }
            set { im = value; }
        }
        #endregion

        #region[Инициализация полей]
        public ComplexClass(double re, double im)
        {
            if (im == 0)
            {
                throw new Exception("На ноль делить нельзя!");
            }
            this.re = re;
            this.im = im;
        }
        #endregion

        #region[Конструкторы]
        public ComplexClass() { }
        public static ComplexClass Plus(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexres = new ComplexClass(a.re + b.re, a.im + b.im);
            return complexres;
        }
        public static ComplexClass Minus(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexres = new ComplexClass(a.re - b.re, a.im - b.im);
            return complexres;
        }
        public static ComplexClass Multiplication(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexres = new ComplexClass(a.re * b.re, a.im * b.im);
            return complexres;
        }
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
    #endregion

    internal class NumbersClass
    {
        static void Main(string[] args)
        {
            ComplexNumberSwitch();

        }

        #region[Методы выполнения задач]
        static void Tasck1()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №1... ");
            Console.WriteLine("========================");
            ComplexNumberPlus();
        }
        static void Tasck2()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №2... ");
            Console.WriteLine("========================");
            ComplexNumberMinus();
        }
        static void Tasck3()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №3... ");
            Console.WriteLine("========================");
            ComplexNumberMultiplication();
        }
        #endregion

        #region[Оператор Switch]
        public static void ComplexNumberSwitch()
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("Мои Задачи: ");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача №1 ");
                Console.WriteLine("2 -> Задача №2 ");
                Console.WriteLine("3 -> Задача №3 ");
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
        #endregion

        #region[Сложение комплесных чисел]
        public static void ComplexNumberPlus()
        {
            Outputhelpers.PrintInfo(3, "Щербаков Алескй Александрович");
            Console.WriteLine("Сложение,  комплексных чисел");
            Console.WriteLine("--------------------------------------");
            ComplexClass complex1 = new ComplexClass();
            Console.Write("Введите действительную часть комплексного числа: ");
            complex1.Re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа: ");
            complex1.Im = int.Parse(Console.ReadLine());
            ComplexClass complex2 = new ComplexClass();
            Console.Write("Введите действительную часть комплексного числа: ");
            complex2.Re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа: ");
            complex2.Im = int.Parse(Console.ReadLine());
            ComplexClass complex3 = ComplexClass.Plus(complex1, complex2);
            Console.WriteLine("Нажмите Enter для продолжения......");
            Console.ReadLine();
            Console.WriteLine("Складываем, нажмите Enter для получения результата");
            Console.ReadLine();
            Console.WriteLine($"Результат сложения комплексных чмсел: {complex1} и {complex2} = {complex3}");
            Console.WriteLine("Нажмите Enter для продолжения и выбора другой задачи");
            Console.ReadLine();
        }
        #endregion

        #region[Вычитание комплексных чисел]
        public static void ComplexNumberMinus()
        {
            Outputhelpers.PrintInfo(3, "Щербаков Алескй Александрович");
            Console.WriteLine("Вычитание, комплексных чисел");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Нажмите Enter для продолжения......");
            Console.ReadLine();
            ComplexClass complex1 = new ComplexClass();
            Console.Write("Введите действительную часть комплексного числа: ");
            complex1.Re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа: ");
            complex1.Im = int.Parse(Console.ReadLine());
            ComplexClass complex2 = new ComplexClass();
            Console.Write("Введите действительную часть комплексного числа: ");
            complex2.Re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа: ");
            complex2.Im = int.Parse(Console.ReadLine());
            //ComplexClass complex3 = ComplexClass.Plus(complex1, complex2);
            ComplexClass complex4 = ComplexClass.Minus(complex1, complex2);
            Console.WriteLine("Вычитаем, нажмите Enter для получения результата");
            Console.ReadLine();
            Console.WriteLine($"Рзультат вычитания комплексных чисел: {complex1} и {complex2} = {complex4}");
            Console.WriteLine("Нажмите Enter для продолжения и выбора другой задачи");
            Console.ReadLine();
        }
        #endregion

        #region[Умножение комплексных чисел]
        public static void ComplexNumberMultiplication()
        {
            Outputhelpers.PrintInfo(3, "Щербаков Алескй Александрович");
            Console.WriteLine("Произведение комплексных чисел");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Нажмите Enter для продолжения......");
            Console.ReadLine();
            ComplexClass complex1 = new ComplexClass();
            Console.Write("Введите действительную часть комплексного числа: ");
            complex1.Re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа: ");
            complex1.Im = int.Parse(Console.ReadLine());
            ComplexClass complex2 = new ComplexClass();
            Console.Write("Введите действительную часть комплексного числа: ");
            complex2.Re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа: ");
            complex2.Im = int.Parse(Console.ReadLine());
            ComplexClass complex5 = ComplexClass.Multiplication(complex1, complex2);
            Console.WriteLine("Умножаем, нажмите Enter для получения результата");
            Console.ReadLine();
            Console.WriteLine($"Результат произвидения копмлексных чисел: {complex1} и {complex2} = {complex5}");
            Console.WriteLine("Нажмите Enter для продолжения и выбора другой задачи");
            Console.ReadLine();
        }
        #endregion
    }
}
