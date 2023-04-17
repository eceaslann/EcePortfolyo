using System.Linq;
using System.Web.Mvc;
using YeniProje.Models;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);

        }
        public PartialViewResult PartialFeaturedSkill()
        {
            var values = db.TblTechnology.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBanner() { return PartialView();}
        public PartialViewResult PartialChoose() { return PartialView(); }
        public PartialViewResult PartialStats()
        {
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.serviceCount = db.TblService.Count();
            ViewBag.averageTechnologyValue = db.TblTechnology.Average(x => x.TechnologyValue);
            ViewBag.happyCustomer = 38;
            return PartialView();
        }
        public PartialViewResult PartialPortfolyo()
        {
            return PartialView();
        }
        public PartialViewResult PartialBrands() { return PartialView(); }
        public PartialViewResult PartialFooter() { return PartialView(); }
        public PartialViewResult PartialScripts() { return PartialView(); }
    }
}
