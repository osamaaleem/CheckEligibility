using System.Web.Mvc;
using WE_Asgn_2.Models;

namespace WE_Asgn_2.Controllers
{
    public class EligibilityController : Controller
    {
        // GET: Eligibility
        ElgCalculator elgCalculator1 = new ElgCalculator();
        public ActionResult Index()
        {
            ViewBag.Provinces = elgCalculator1.ProvinceList();
            ViewBag.Eligible = "-------";
            return View();
        }
        [HttpPost]
        public ActionResult Index(ElgCalculator elgCalculator)
        {
            ViewBag.Provinces = elgCalculator.ProvinceList();
            ViewBag.Eligible = elgCalculator.IsEligible();
            return View();
        }
    }
}