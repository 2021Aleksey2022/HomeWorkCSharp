using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork5
{
    public  class Massage1
    {
        private string str;

        private string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-" };

        public Massage1(string str)
        {
            str = "Лейтенант шел по желтому строительному песку нагретому дневным палящим солнцем " +
                "Он был мокрым от кончиков пальцев до кончиков волос все его тело было усеяно царапинами " +
                "от острой колючей проволоки и ныло от сводящей с ума боли но он был жив и направлялся к командному штабу " +
                "который виднелся на горизонте метрах в пятистах ";
            this.str = str;
            
        }
        static void Main(string[] args)
        {
            Massage1 massage1 = new Massage1(" ");
            //Metod();
            //Metod1();
            //Metod2();
            massage1.GetStringFromWords();
        }
        // public static int max { get; private set; }


        /// <summary>
        /// Выводим слова сообщения, которые содержат не более n букв.
        /// </summary>

        public void Metod()
        {
            Massage1 massage1 = new Massage1(" ");
            Console.WriteLine("\t\t\t\t\tДано Сообщение, нажмите ENTER... ");
            Console.ReadLine();
            Console.WriteLine(massage1.str);
            Console.WriteLine("                                            ");
            Console.WriteLine("\t\t\t\t\tНажмите ENTER, для продолжения... ");
            Console.ReadLine();
            Console.WriteLine("Введите количество символов в слове.");
            Console.Write("Например: 5, и узнаем сколько слов из пяти букв, в этом сообщении: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            var msv = massage1.str.Split(new char[] { ' ', '.', ',', ':', ';', '?', '!', '-' }).Where(x => x.Length == n).ToArray();

            foreach (var item in msv)
            {
                Console.WriteLine($"{i}:{item}");
                i++;
            }
            Console.WriteLine($"Всего слов нашлось в этом сообщени: {i - 1} ");
            Console.WriteLine("                                            ");
            Console.WriteLine("\t\t\t\t\tНажмите ENTER, для продолжения... ");
            Console.ReadLine();
        }
        public void Metod1()
        {
            Massage1 massage1 = new Massage1(" ");
            Console.WriteLine("Удаляем из сообщения все слова, которые заканчиваются на заданную букву.");
            Console.WriteLine("                                            ");
            Console.WriteLine("\t\t\t\t\tВводим сообщение.Нажмите ENTER, для продолжения... ");
            Console.ReadLine();
            Console.WriteLine(massage1.str);
            Console.WriteLine("                                            ");
            Console.WriteLine("\t\t\t\t\tНажмите ENTER, для ввода буквы... ");
            Console.ReadLine();
            Console.WriteLine("Введите букву, чтоб удалить слова , котрые заканчиваются на неё");
            Console.Write("И нажмите ENTER, для вывода нового сообщения: ");
            string k = Console.ReadLine();
            Console.WriteLine("                                            ");
            Console.WriteLine((Regex.Replace(massage1.str, "[^ ]{0,}" + k + " ", "")).Trim());
            Console.WriteLine("                                            ");
            Console.WriteLine("\t\t\t\t\tНажмите ENTER, для продолжения... ");
            Console.ReadLine();
        }
        public string Metod2()
        {
            Massage1 massage1 = new Massage1(" ");
            Console.WriteLine("Находим самое длинное слово сообщения.Нажмите ENTER, для продолжения...");
            Console.WriteLine("                                      ");
            Console.ReadLine();
            Console.WriteLine("\t\t\t\t\tВводим сообщение.Нажмите ENTER... ");
            Console.WriteLine("                                      ");
            Console.ReadLine();
            Console.WriteLine(massage1.str);
            Console.WriteLine("                                      ");
            Console.WriteLine("\t\t\tНажмите ENTER, для поиска самого длинного слова в сообщении... ");
            Console.ReadLine();
            string[] words = massage1.str.Split(new[] { ' ', '.', ',', ':', ';', '?', '!', '-' }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine("                            ");
            Console.WriteLine($"Самое длинное слово: {word}");
            Console.WriteLine("                            ");
            Console.WriteLine($"И наконец то мы закончили все итерации, спасибо за просмотр. Нажмите ENTER для выхода...");
            Console.ReadLine();
            return word;
        }
        public StringBuilder GetStringFromWords()
        {

            //minWordlength = -1;
            Massage1 massage1 = new Massage1(" ");
          
            //var builder = new StringBuilder();
            string[] words = massage1.str.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });           
            StringBuilder result = new StringBuilder();
            int max = massage1.FindMaxLengthWord().Length;
            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    result.Clear();
                    max = word.Length;
                }
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }

            Console.WriteLine("Полученная строка самых длинных слов: " + result);
            Console.ReadLine();
            return result;

        }
        public string FindMaxLengthWord()
        {
            Massage1 massage1 = new Massage1(" ");
            string[] words = massage1.str.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            //Console.WriteLine("Слово с самой большой длинной: " + maxWord);
            return maxWord;
        }
    }
}
