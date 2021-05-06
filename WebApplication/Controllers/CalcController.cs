using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class CalcController : Controller
    {
        private const int secretToken = 55;

        public IActionResult ManualSingle()
        {
            if (Request.Method.ToLower() == "post")
            {
                return FormHandler();
            }

            return View();
        }

        [HttpGet]
        public IActionResult ManualSeparate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ManualSeparate(int token)
        {
            if (token != secretToken)
            {
                return Forbid();
            }

            return FormHandler();
        }

        private IActionResult FormHandler()
        {
            var firstString = Request.Form.FirstOrDefault(p => p.Key == "first").Value;
            var first = Int32.Parse(firstString);

            var secondString = Request.Form.FirstOrDefault(p => p.Key == "second").Value;
            var second = Int32.Parse(secondString);

            var operationString = Request.Form.FirstOrDefault(p => p.Key == "operation").Value;
            var operationInt = Int32.Parse(operationString);
            var operation = (Operation)operationInt;

            return View("Result", new ResultModel(first, second, operation));
        }

        public IActionResult ModelParameters(CalcModel model)
        {
            if (Request.Method.ToLower() == "post")
            {
                return View("Result", new ResultModel(model));
            }

            return View();
        }

        [HttpGet]
        public IActionResult ModelSeparate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModelSeparate(CalcModel model)
        {
            return View("Result", new ResultModel(model));
        }
    }
}
