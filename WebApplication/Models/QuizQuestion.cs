using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public int CorrectAnswer { get; set; }

        [Required]
        public int UserAnswer { get; set; }

        public QuizQuestion()
        {
            var rand = new Random();
            var first = rand.Next() % 11;
            var second = rand.Next() % 11;
            var operation = (Operation)(rand.Next() % 2);

            Question = operation switch
            {
                Operation.Plus => $"{first} + {second} = ",
                Operation.Minus => $"{first} - {second} = ",
                _ => string.Empty
            };

            CorrectAnswer = operation switch
            {
                Operation.Plus => first + second,
                Operation.Minus => first - second,
                _ => 0
            };
        }
    }
}
