using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class QuizController : Controller
    {
        private static Quiz quiz;
        private static QuizQuestion currentQuizQuestion;

        [HttpGet]
        public IActionResult Game()
        {
            quiz = new Quiz();
            currentQuizQuestion = new QuizQuestion();

            return View(currentQuizQuestion);
        }

        [HttpPost]
        public IActionResult Game(QuizQuestion quizQuestion)
        {
            currentQuizQuestion.UserAnswer = quizQuestion.UserAnswer;
            quiz.QuizQuestions.Add(currentQuizQuestion);

            currentQuizQuestion = new QuizQuestion();

            return View(currentQuizQuestion);
        }

        [HttpGet]
        public IActionResult Result()
        {
            return View(quiz);
        }
    }
}
