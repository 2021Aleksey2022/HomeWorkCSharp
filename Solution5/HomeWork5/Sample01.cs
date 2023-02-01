using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork5
{
    public static class Sample01
    {
        static void Main(string[] args)
        {
            //LoginPassword();
            LoginPasswordNumber();
        }
        public static void LoginPassword()
        {
            Console.Write("Введите логин: ");
            string str = Console.ReadLine();
            Regex regex = new Regex("^[A-Za-z]{1,9}[0-9]{0,9}$");
            Console.Write(regex.IsMatch(str));
            Console.ReadLine();
        }
        public static void LoginPasswordNumber()
        {
            int count = 1;

            Console.Write("Введите логин: ");
            string str1 = Console.ReadLine();
            if (str1.Length < 2 || str1.Length > 10)
            {
                Console.WriteLine($"\t\t\t\t\tВаш логин: {str1}, не соотвествует требованиям");
                Console.WriteLine($"Вы использовали {count} попытку ");
                Console.WriteLine("\t\t\t\t\tНажмите Enter, и попробуйте снова...");
                Console.ReadLine();
                count++;
            }
            if (char.IsDigit(str1[0]))
            {
                Console.WriteLine($"\t\t\t\t\tВаш логин: {str1}, начинается с цифры, что не соотвествует требованиям ");
                Console.WriteLine($"Вы использовали {count} попытку ");
                Console.WriteLine("\t\t\t\t\tНажмите Enter, и попробуйте снова...");
                Console.ReadLine();
                count++;
            }
            if (count == 3)
            {
                Console.WriteLine($"\t\t\t\t\tВы использовали {count} попытку, к сожалению вы не смогли авторизоваться");
                Console.WriteLine("\t\t\t\t\tНажмите Enter для выхода...");
                Console.ReadLine();

            }
            bool flag = true;
            for (int i = 0; i < str1.Length; i++)
            {
                if (!(char.IsDigit(str1[i]) || str1[i] >= 'a' && str1[i] <= 'z' || str1[i] >= 'A' && str1[i] <= 'Z'))
                {
                    flag = false;
                    Console.WriteLine("\t\t\tВведены недопустимые символы, видимо забыли переключтся на другой язык: Alt + Shift");
                    Console.WriteLine($"Вы использовали {count} попытку ");
                    Console.WriteLine("\t\t\t\t\tНажмите Enter, и попробуйте снова...");
                    Console.ReadKey();
                    count++;
                }
                if (flag)
                {
                    Console.WriteLine($"\t\t\t\t\tВаш логин: {str1}, соотвествует требованиям!");
                    Console.WriteLine("\t\t\t\t\tНажмите Enter для выхода...");
                    Console.ReadLine();
                    break;
                }

            }

        }

    }
}
