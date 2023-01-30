using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Quest
    {       
        static void Main(string[] args)
        {
            
            var game = new Game("Baza.csv");
            game.EndOfGame += (sender, e) =>
            {
                Console.WriteLine($"Questions asked: {e.QuestionPassed}. Mistakes made: {e.MistakesMade}");
                Console.WriteLine(e.IsWin ? "You Win!" : "You Lost!");
            };
            while(game.GameStatus == GameStatus.GameInProgress)
            {
                Question q = game.GetNextQuestion();
                Console.WriteLine(q.Text);
                string answer = Console.ReadLine();
              // string boolAnswer = answer;
                if(q.CorrectAnswer == answer)
                {
                    Console.Write("Вы угодали");
                }
                else
                {
                    Console.WriteLine("Вы не правы");
                }
                game.GiveAnswer(answer);
            }
            Console.ReadLine();
        }
       
    }
}
