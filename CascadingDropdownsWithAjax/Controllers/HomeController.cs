using CascadingDropdownsWithAjax.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CascadingDropdownsWithAjax.Controllers
{
    public class HomeController : Controller
    {
        private List<MakeModelYear> All = new List<MakeModelYear>() {
            new MakeModelYear(1, "2009", "Honda", "Fit"), 
            new MakeModelYear(2, "2009", "Honda", "Accord"), 
            new MakeModelYear(3, "2009", "Honda", "Civic"), 
            new MakeModelYear(4, "2009", "Toyota", "Sentra"), 
            new MakeModelYear(5, "2009", "Toyota", "Rav4"), 
            new MakeModelYear(6, "2009", "Nissan", "Maxima"), 
            new MakeModelYear(7, "2010", "Toyota", "Sentra"), 
            new MakeModelYear(8, "2010", "Toyota", "Rav4"), 
            new MakeModelYear(9, "2010", "Nissan", "Maxima"), 
            };

        public JsonResult GetYears()
        {
            var allYears = All.Select(mmy => mmy.Year).Distinct();
            return Json(allYears, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMakesFor(string year)
        {
            var allMakesForGivenYear = All.Where(mmy => mmy.Year == year).Select(mmy => mmy.Make).Distinct();
            return Json(allMakesForGivenYear, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetModelsFor(string year, string make)
        {
            var allModelsForGivenYearAndMake = All.Where(mmy => mmy.Year == year && mmy.Make == make).Select(mmy => mmy.Model).Distinct();
            return Json(allModelsForGivenYearAndMake, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}