using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Question
    {
        internal static object questions;

        public Question( string correctAnswer, string answer)
        {
           
            Answer = answer;
        }

        public string Text { get; }
        public string Answer { get; }
        public string CorrectAnswer { get; }
    }
    internal class TrueOrFalse
    {
    }
}
