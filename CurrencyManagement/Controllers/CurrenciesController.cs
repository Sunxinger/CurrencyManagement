using System.Linq;
using System.Web.Mvc;
using CurrencyManagement.Models;

namespace CurrencyManagement.Controllers
{
    public class CurrenciesController : Controller
    {
        private CurrencyDbContext db = new CurrencyDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCurrencies()
        {
            var currencies = db.Currencies.Select(c => new
            {
                c.CurrencyID,
                c.CountryName,
                c.CurrencyCode,
                c.CurrencyName
            }).ToList();

            return Json(new { success = true, data = currencies }, JsonRequestBehavior.AllowGet);
        }
    }
}
