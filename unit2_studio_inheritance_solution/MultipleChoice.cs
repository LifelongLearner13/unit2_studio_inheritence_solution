using System;
using System.Collections.Generic;

namespace unit2_studio_inheritance_solution
{
    public class MultipleChoice : Question
    {
        public List<string> PossibleAnswers { get; set; }
        private int CorrectAnswer { get; set; }

        public MultipleChoice(int pointValue, string text, int correctAnswer, List<string> possibleAnswers) : base(pointValue, text)
        {
            CorrectAnswer = correctAnswer;
            PossibleAnswers = possibleAnswers;
            PointValue = 1;
        }


        public override void DisplayAnswers()
        {
            foreach (string answer in PossibleAnswers)
            {
                Console.WriteLine(answer);
            }
        }

        private bool CheckAnswer(int possibleAnswer)
        {
            return possibleAnswer == CorrectAnswer ? true : false;
        }

        public override int GetAnswers()
        {
            Console.WriteLine("What will your answer be? Enter the number of the option you believe is correct. For example, to select the first option, enter 1");
            string userAnswer = Console.ReadLine();
            int result = int.Parse(userAnswer);
            return CheckAnswer(result) ? 1 : 0;
        }
    }

}
