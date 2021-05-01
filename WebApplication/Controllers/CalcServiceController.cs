using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication.Models;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class CalcServiceController : Controller
    {
        private readonly CalcService _calcService;

        public CalcServiceController(CalcService calcService)
        {
            _calcService = calcService;
        }

        public IActionResult PassUsingModel()
        {
            var model = new PassUsingModel
            {
                First = _calcService.First,
                Second = _calcService.Second,
                Sum = _calcService.Sum,
                Sub = _calcService.Sub,
                Mult = _calcService.Mult,
                Div = _calcService.Div
            };

            return View(model);
        }

        public IActionResult PassUsingViewData()
        {
            ViewData["First"] = _calcService.First;
            ViewData["Second"] = _calcService.Second;
            ViewData["Sum"] = _calcService.Sum;
            ViewData["Sub"] = _calcService.Sub;
            ViewData["Mult"] = _calcService.Mult;
            ViewData["Div"] = _calcService.Div;
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            ViewBag.First = _calcService.First;
            ViewBag.Second = _calcService.Second;
            ViewBag.Sum = _calcService.Sum;
            ViewBag.Sub = _calcService.Sub;
            ViewBag.Mult = _calcService.Mult;
            ViewBag.Div = _calcService.Div;
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
