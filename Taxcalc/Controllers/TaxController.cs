using Microsoft.AspNetCore.Mvc;
using Taxcalc.Models;

namespace Taxcalc.Controllers
{
    public class TaxController : Controller
    {
        [HttpGet]
        public ActionResult Calculate()
        {
            return View(new TaxModel());
        }

        [HttpPost]
        public ActionResult Calculate(TaxModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateTax();
                ViewBag.Result = $"Estimated tax owed in {model.Country}: ₦{model.TaxOwed:N2}";
            }

            return View(model);
        }
    }
}

