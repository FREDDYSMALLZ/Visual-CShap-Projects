using System.Web.Mvc;

namespace BibleVerseApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        

    }
}