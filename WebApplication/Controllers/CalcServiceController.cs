using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class CalcServiceController : Controller
    {
        private readonly Random rand;

        public CalcServiceController()
        {
            rand = new Random();
        }

        public IActionResult PassUsingModel()
        {
            var model = new PassUsingViewModel
            {
                First = rand.Next() % 11,
                Second = rand.Next() % 11
            };

            return View(model);
        }

        public IActionResult PassUsingViewData()
        {
            ViewData["First"] = rand.Next() % 11;
            ViewData["Second"] = rand.Next() % 11;
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            ViewBag.First = rand.Next() % 11;
            ViewBag.Second = rand.Next() % 11;
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
