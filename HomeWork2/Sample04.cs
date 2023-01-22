using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;

namespace HomeWork2
{    
    internal class Sample04
    {
         static string Login = "root";
         static string Password = "GeekBrains";

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Outputhelpers.PrintInfo(2, "Щербаков Алексей Алескандрович");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Проверка логина и пароля ");
            Console.WriteLine("-------------------------");
            LoginPassword();
        }
        public static void LoginPassword()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            int counter = 3;
            while(counter >= 0)
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine().ToString();
                Console.Write("Ввудите пароль: ");
                string password = Console.ReadLine().ToString();
                if (login == Login && password == Password)

                {
                    Console.WriteLine("Вы успешно авторизовались");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Нажмите любую клавишу для выхода");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Вы ввели некоректно логин или пароль, поробуйте ещё раз, у вас {counter} попытка");
                    if(counter == 0)
                    {
                        Console.WriteLine($"У вас отсалось {counter} попыток, к сожалению вы не авторизовались");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Нажмите любую клавишу для выхода: ");
                        Console.ReadKey();
                        break;
                    }
                    counter--;
                }               
            }
        }

    }
}
