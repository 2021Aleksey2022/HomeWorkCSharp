using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace HomeWork4
{
    public enum GameStatus
    {
        GameIsOver,
        GameInProgress
    }
    public class GameResultEventArgs : EventArgs
    {
        public GameResultEventArgs(int questionPassed, int mistakesMade, bool isWin)
        {
            QuestionPassed = questionPassed;
            MistakesMade = mistakesMade;
            IsWin = isWin;
        }

        public int QuestionPassed { get; }
        public int MistakesMade { get; }
        public bool IsWin { get; }
    }
    public class Game
    {
        private readonly List<Question> questions;
        private readonly int allowedMistakes;
        private int counter;
        private int mistakes;

        public event EventHandler<GameResultEventArgs> EndOfGame;

        public GameStatus GameStatus { get; private set; }

        public Game(string filePath, int allowedMistakes = 2)
        {
            if (filePath == null) throw new ArgumentNullException("filePath");
            if (filePath == "") throw new ArgumentNullException("filePath should not be empty");
            if (allowedMistakes < 2) throw new ArgumentException("allowedMistakes should be >= 2");

            List<Question> question = File.ReadAllLines(filePath)
                                                 .Select(x =>
                                                 {
                                                     string[] parts = x.Split('.');
                                                     //string text = parts[0];
                                                     string answer = parts[0];
                                                     string correctAnswer = parts[1];
                                                     return new Question( correctAnswer, answer);
                                                 }).ToList();
            this.questions = question;
            this.allowedMistakes = allowedMistakes;
            GameStatus = GameStatus.GameInProgress;
        }
        public Question GetNextQuestion()
        {
            
            return questions[counter];
        }
        public void GiveAnswer(string answer)
        {
            if (questions[counter].CorrectAnswer != answer) 
            {
                mistakes++;
            }
            if(counter == questions.Count- 1 || mistakes > allowedMistakes) 
            {
                GameStatus = GameStatus.GameIsOver;
                if(EndOfGame != null)
                {
                    EndOfGame(this, new GameResultEventArgs(counter, mistakes, mistakes <= allowedMistakes));
                }
                counter++;
            }
        }
    }
}
