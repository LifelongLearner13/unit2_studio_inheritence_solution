using System;
using System.Collections.Generic;

namespace unit2_studio_inheritance_solution
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public int Score { get; set; }
        private int Total { get; set; }

        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Score = 0;
            Total = 0;
            foreach (Question question in questions)
            {
                Total += question.PointValue;
            }
        }

        public void AddQuestion(Question newQuestion)
        {
            Questions.Add(newQuestion);
            Total += newQuestion.PointValue;
        }

        public void Run()
        {
            foreach (Question question in Questions)
            {
                question.DisplayQuestion();
                question.DisplayAnswers();
                int pts = question.GetAnswers();
                UpdateScore(pts);
            }

            Console.WriteLine("You finished the quiz! Your score is: " + Score + "/" + Total);
        }

        private void UpdateScore(int x)
        {
            Score += x;
        }

    }

}
