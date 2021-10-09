using System;
namespace unit2_studio_inheritance_solution
{
    public class TrueOrFalse : Question
    {
        private bool CorrectAnswer { get; set; }

        public TrueOrFalse(int pointValue, string text, bool correctAnswer) : base(pointValue, text)
        {
            PointValue = 1;
            CorrectAnswer = correctAnswer;
        }

        private bool CheckAnswer(bool possibleAnswer)
        {
            return possibleAnswer == CorrectAnswer ? true : false;
        }

        public override void DisplayAnswers()
        {
            Console.WriteLine("True or False");
        }

        public override int GetAnswers()
        {
            Console.WriteLine("What will your answer be? Type 't' for True and 'f' for False");
            string userAnswer = Console.ReadLine();
            bool result = userAnswer.IndexOf('t') >= 0 ? true : false;
            return CheckAnswer(result) ? 1 : 0;
        }
    }

}
