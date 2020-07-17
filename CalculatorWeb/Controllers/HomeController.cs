using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.OneArgClasses;
using Calculator.TwoArgsClasses;

namespace CalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                 new SelectListItem() { Value = "mult", Text = "multiply" },
                 new SelectListItem() { Value = "sum", Text = "sum" },
                 new SelectListItem() { Value = "minus", Text = "minus" },
                 new SelectListItem() { Value = "div", Text = "division" },
                 new SelectListItem() { Value = "pow", Text = "pow" },
                 new SelectListItem() { Value = "exp", Text = "exp" },
                 new SelectListItem() { Value = "sqrt", Text = "sqrt" },
                 new SelectListItem() { Value = "tg", Text = "tg" },
                 new SelectListItem() { Value = "ctg", Text = "ctg" },
                 new SelectListItem() { Value = "lg", Text = "lg" },
                 new SelectListItem() { Value = "ln", Text = "ln" },
                 new SelectListItem() { Value = "fact", Text = "!" },
                 new SelectListItem() { Value = "proc", Text = "" }
            };         
            return View();
        }
        [HttpPost]
        public ActionResult Index(
        double firstNumber,
        double secondNumber,
        string operation)
        {
            string[] arr = { "mult", "div", "plus", "minus", "pow" };
            double result;
            if (arr.Contains(operation))
            {
                ITwoArgCalculator calculator = TwoArgFactory.CreateCalculator(operation);
                result = calculator.Calculate(firstNumber, secondNumber);
            }
            else
            {
                IOneArgCalculator calculator = OneArgFactory.CreateCalculator(operation);
                result = calculator.Calculate(firstNumber);
            }

            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                 new SelectListItem() { Value = "mult", Text ="multiply" },
                 new SelectListItem() { Value = "sum", Text ="sum" },
                 new SelectListItem() { Value = "minus", Text ="minus" },
                 new SelectListItem() { Value = "div", Text ="division" },
                 new SelectListItem() { Value = "pow", Text = "pow" },
                 new SelectListItem() { Value = "exp", Text = "exp" },
                 new SelectListItem() { Value = "sqrt", Text = "sqrt" },
                 new SelectListItem() { Value = "tg", Text = "tg" },
                 new SelectListItem() { Value = "ctg", Text = "ctg" },
                 new SelectListItem() { Value = "lg", Text = "lg" },
                 new SelectListItem() { Value = "ln", Text = "ln" },
                 new SelectListItem() { Value = "fact", Text = "!" },
                 new SelectListItem() { Value = "proc", Text = "" }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}