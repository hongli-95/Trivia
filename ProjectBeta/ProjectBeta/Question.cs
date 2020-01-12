//Hong Li, CIS 345, Project Final, T TH 10:30 am
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    [Serializable]
    public class Question
    {
        private string title;
        private string correctAnswer;
        private string choiceOne;
        private string choiceTwo;
        private string choiceThree;
        private string choiceFour;
        private string feedback;

        public Question()
        {
            this.Title = "";
            this.CorrectAnswer = "";
            this.ChoiceOne = "";
            this.ChoiceTwo = "";
            this.ChoiceThree = "";
            this.ChoiceFour = "";
            this.Feedback = "";
        }

        public Question(string title, string correctAnswer, string choiceOne, string choiceTwo, string choiceThree, string choiceFour, string feedback)
        {
            this.title = title;
            this.correctAnswer = correctAnswer;
            this.choiceOne = choiceOne;
            this.choiceTwo = choiceTwo;
            this.choiceThree = choiceThree;
            this.choiceFour = choiceFour;
            this.Feedback = feedback;
        }

        public override string ToString()
        {
            return title;
        }

        public string Title { get => title; set => title = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public string ChoiceOne { get => choiceOne; set => choiceOne = value; }
        public string ChoiceTwo { get => choiceTwo; set => choiceTwo = value; }
        public string ChoiceThree { get => choiceThree; set => choiceThree = value; }
        public string ChoiceFour { get => choiceFour; set => choiceFour = value; }
        public string Feedback { get => feedback; set => feedback = value; }
    }
}
