using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using CalcGirl.Double;

namespace WebInterface.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.operations = new List<SelectListItem>
            {
                new SelectListItem { Value = "add", Text = "Сложение" },
                new SelectListItem { Value = "minus", Text = "Вычитание" },
                new SelectListItem { Value = "multyply", Text = "Умножение" },
                new SelectListItem { Value = "divide", Text = "Деление" }
            };
            return View();
        }

        [HttpPost]
        public ActionResult Index(double first, double second, string name)
        {
            try
            {
                ICalculator calc = CalculatorFactory.CreateCalculator(name);
                var result = calc.Calculate(first, second);
                TempData["result"] = result;
            }
            catch (Exception Ex)
            {
                TempData["result"] = "Неправельный ввод: " + Ex.Message;
            }

            return RedirectToAction("Result");
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

        public ActionResult Result()
        {
            ViewBag.result = TempData["result"];
            TempData.Keep();
            return View();
        }
    }
}