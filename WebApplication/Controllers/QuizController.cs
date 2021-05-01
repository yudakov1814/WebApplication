using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class QuizController : Controller
    {
        private static Quiz quiz;

        [HttpGet]
        public IActionResult Game()
        {
            quiz = new Quiz();
            var quizQuestion = new QuizQuestion();

            return View(quizQuestion);
        }

        [HttpPost]
        public IActionResult Game(QuizQuestion quizQuestion)
        {
            quiz.QuizQuestions.Add(quizQuestion);

            var newQuizQuestion = new QuizQuestion();

            return View(newQuizQuestion);
        }

        [HttpGet]
        public IActionResult Result()
        {
            return View(quiz);
        }
    }
}
