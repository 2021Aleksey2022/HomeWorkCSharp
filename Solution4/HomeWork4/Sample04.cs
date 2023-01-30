using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork4
{
    struct LoginPassword
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
    public class Sample04
    {       
        static void Main(string[] args)
        {
            Sample04 sample04 = new Sample04();
            sample04.SaveFile();
           
        }
        public void LoadFromFile()
        {

            using (FileStream stream1 =  File.OpenRead("ArrayNumber.txt"))
            {
                //LoginPassword loginPassword = new LoginPassword();
                byte[] textFromFile = new byte[stream1.Length];
                stream1.Read(textFromFile, 0, textFromFile.Length);
                string text = System.Text.Encoding.Default.GetString(textFromFile);
                Console.WriteLine($"Ваш логин: {text}");
                stream1.Close();
                SaveFail1();
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
                Console.Write($"Ваш пароль: {text1} ");
                Console.WriteLine("Поздравляю, вы успешно авторизовались");
                stream2.Close();
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
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
                    Console.WriteLine($"Вы ввели: {a}");
                    stream.Write(textFromFile, 0, textFromFile.Length);
                    Console.WriteLine("-----------------------------");
                    stream.Close();
                    LoadFromFile();
                }
                if (a != loginPassword.Login)
                {
                    Console.WriteLine($"Вы ввели: {a}");
                    stream.Close();
                    SaveFail1();
                }
            }          
            Console.ReadLine();
        }
        public void SaveFail1()
        {
            LoginPassword loginPassword = new LoginPassword();
            System.Console.Write("Введите пароль:  ");
            string b = Console.ReadLine().ToString();
            using (FileStream stream2 = new FileStream("ArrayNumber.txt", FileMode.Append))
            {
                byte[] textFromFile1 = System.Text.Encoding.Default.GetBytes(b);
                if(b == loginPassword.Password)
                {
                    Console.WriteLine($"Вы ввели: {b}");
                    stream2.Write(textFromFile1, 0, textFromFile1.Length);
                    Console.WriteLine("-----------------------------");
                    stream2.Close();
                    LoadFromFile1();
                }
                else
                {
                    Console.WriteLine("К сожалению вы ввели не корректно логин или пароль, порбоуйте ещё раз");
                    Console.ReadKey();
                }
            }
        }
    }
}
