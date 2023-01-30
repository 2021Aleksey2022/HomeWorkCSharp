using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    struct LoginPassword2
    {
        static string login = "root";
        static string password = "GeekBrains";
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
    }
    internal class ReadingLoginPassword
    {
        string path = @"C:\Users\manay\Desktop\LoginPassword.txt";
        static void Main(string[] args)
        {
            ReadingLoginPassword readingLoginPassword = new ReadingLoginPassword();
            readingLoginPassword.SaveFileLoginPassword();
        }
        public void SaveFileLoginPassword()
        {
            LoginPassword2 loginPassword = new LoginPassword2();
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate)) 
            {
                using (StreamWriter stream = new StreamWriter(file))
                {
                    System.Console.Write("Введите логин: ");
                    string a = Console.ReadLine().ToString();
                    stream.WriteLine($"Логин: {a}");
                    System.Console.Write("Введите пароль: ");
                    string b = Console.ReadLine().ToString();
                    stream.WriteLine($"Пароль: {b}");
                    stream.Close();
                    using (FileStream stream2 = File.OpenRead(path))
                    {
                        if (a == loginPassword.Login && b == loginPassword.Password)
                        {
                            Console.WriteLine($"Ваш логин: {a} и Ваш пароль: {b}");
                            Console.WriteLine("Поздравляю, вы успешно авторизовались");
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Нажмите на любую клавишу для выхода");
                        }
                        else
                        {
                            Console.WriteLine($"К сожалению вы ввели не корректно логин или пароль, порбоуйте ещё раз");
                            Console.WriteLine("Нажмите любую клавишу для выхода: ");
                        }
                        Console.ReadKey();
                    }
                }                                
            }
        }
    }
}
