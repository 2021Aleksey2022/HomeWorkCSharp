using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork4
{
    struct LoginPassword
    {
         static string login = "root";
         static string password = "GeekBrains";

        //public string text;
        //private string el;

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
    public class Sample04
    {



        //public int[] a;
        static void Main(string[] args)
        {
            Sample04 sample04 = new Sample04();
            sample04.SaveFile();
            sample04.LoadFromFile();
            sample04.SaveFail1();
            //sample04.LoadFromFile1();
        }



        public void LoadFromFile()
        {

            using (FileStream stream1 = File.OpenRead("ArrayNumber.txt"))
            {
                //LoginPassword loginPassword = new LoginPassword();
                byte[] textFromFile = new byte[stream1.Length];
                stream1.Read(textFromFile, 0, textFromFile.Length);
                string text = System.Text.Encoding.Default.GetString(textFromFile);
                Console.WriteLine($"Ваш логин: {text}");

            }
        }
        public void LoadFromFile1()
        {
            using (FileStream stream2 = File.OpenRead("ArrayNumber.txt"))
            {
                //LoginPassword loginPassword = new LoginPassword();
                byte[] textFromFile1 = new byte[stream2.Length];
                stream2.Read(textFromFile1, 0, textFromFile1.Length);
                string text1 = System.Text.Encoding.Default.GetString(textFromFile1);
                Console.WriteLine($"Ваш пароль: {text1}");

            }
            Console.WriteLine("Поздравляю, вы успешно авторизовались");
            Console.ReadLine();
        }
        public void SaveFile()
        {
            LoginPassword loginPassword = new LoginPassword();
            System.Console.Write("Введите логин:  ");
            string a = Console.ReadLine().ToString();

            using (FileStream stream = new FileStream("ArrayNumber.txt", FileMode.Open))
            {
                byte[] textFromFile = System.Text.Encoding.Default.GetBytes(a);
                if (a == loginPassword.Login)
                {
                    Console.WriteLine($"Вы ввели: {a.ToString()}");
                    Console.WriteLine("Вы ввели логин  корректно");
                   
                }
                if (a != loginPassword.Login)
                {
                    Console.WriteLine($"Вы ввели: {a.ToString()}");
                    Console.WriteLine("Вы ввели логин не корректно");
                }
                stream.Write(textFromFile, 0, textFromFile.Length);
                Console.WriteLine("-----------------------------");
            }
            Console.ReadLine();
        }
        public void SaveFail1()
        {
            LoginPassword loginPassword = new LoginPassword();
            System.Console.Write("Введите пароль:  ");
            string b = Console.ReadLine().ToString();
            using (FileStream stream2 = new FileStream("ArrayNumber.txt", FileMode.Open))
            {
                byte[] textFromFile1 = System.Text.Encoding.Default.GetBytes(b);
                if (b == loginPassword.Password)
                {
                    Console.WriteLine($"Вы ввели: {b.ToString()}");
                    Console.WriteLine("Вы ввели пароль  корректно");                  
                }
                if (b != loginPassword.Password)
                {
                    Console.WriteLine($"Вы ввели: {b.ToString()}");
                    Console.WriteLine("Вы ввели пароль или логин не корректно");
                    Console.WriteLine("нажмите любю клавишу для выхода из приложения.....");
                }
                stream2.Write(textFromFile1, 0, textFromFile1.Length);
                Console.WriteLine("-----------------------------");
                Console.ReadKey();
                

            }
        }
    }
}
