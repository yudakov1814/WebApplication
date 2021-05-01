using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Quiz
    {
        public IList<QuizQuestion> QuizQuestions { get; set; }

        public Quiz()
        {
            QuizQuestions = new List<QuizQuestion>();
        }
    }
}
