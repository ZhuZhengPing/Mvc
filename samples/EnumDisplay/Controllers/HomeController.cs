
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EnumDisplay.Controllers
{
    public class AClass
    {
        public DayOfWeek DayOfWeek { get; set; }
        [DisplayFormat(DataFormatString = "Month: {0}")]
        public Month Month { get; set; }
    }

    public enum Month
    {
        [Display(Name = "January")]
        FirstOne,
        LastOne
    }

    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new AClass { DayOfWeek = DayOfWeek.Friday, Month = Month.FirstOne });
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
