using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    struct LoginPassword1
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
    public class ReadingFile
    {
        public void LoadFromFile()
        {

            using (FileStream stream1 = File.OpenRead("ArrayNumber.txt"))
            {
                byte[] textFromFile = new byte[stream1.Length];
                stream1.Read(textFromFile, 0, textFromFile.Length);
                string text = System.Text.Encoding.Default.GetString(textFromFile);
                using (FileStream stream2 = File.OpenRead("ArrayNumber.txt"))
                {
                    byte[] textFromFile1 = new byte[stream2.Length];
                    stream2.Read(textFromFile1, 0, textFromFile1.Length);
                    string text1 = System.Text.Encoding.Default.GetString(textFromFile1);
                }
                Console.WriteLine("Поздравляю, вы успешно авторизовались");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Нажмите на любую клавишу для выхода");
                Console.ReadKey();
                stream1.Close();
                
            }
        }
        public void SaveFile()
        {
            LoginPassword loginPassword = new LoginPassword();
            System.Console.Write("Введите логин:  ");
            string a = Console.ReadLine().ToString();
            System.Console.Write("Введите пароль:  ");
            string b = Console.ReadLine().ToString();
            using (FileStream stream = new FileStream("ArrayNumber.txt", FileMode.Open))
            {
                byte[] textFromFile = System.Text.Encoding.Default.GetBytes(a);
                byte[] textFromFile1 = System.Text.Encoding.Default.GetBytes(b);
                if (a == loginPassword.Login && b == loginPassword.Password)
                {
                    Console.WriteLine($"Ваш логин: {a} и Ваш пароль: {b}");
                    stream.Write(textFromFile, 0, textFromFile.Length);
                    Console.WriteLine("-----------------------------");
                    stream.Close();
                    LoadFromFile();
                }
                else 
                {
                    Console.WriteLine("К сожалению вы ввели не корректно логин или пароль, порбоуйте ещё раз");
                    Console.ReadKey();
                }
            }
        }
        static void Main(string[] args)
        {
            ReadingFile readingFile = new ReadingFile();
            readingFile.SaveFile();
        }
    }
}
