using System.Collections.Generic;
using System.Web.Mvc;
using v8proj.Web.Model;

namespace v8proj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<eUseControl> cars = new List<eUseControl>
            {
                new eUseControl { CartName = "Mercedes", CartDescription = "Good car", CartPrice = 10000, CartImage = "https://via.placeholder.com/400x300" },
                new eUseControl { CartName = "BMW", CartDescription = "Sporty and powerful", CartPrice = 12000, CartImage = "https://via.placeholder.com/400x300" },
                new eUseControl { CartName = "Audi", CartDescription = "Luxury and comfort", CartPrice = 15000, CartImage = "https://via.placeholder.com/400x300" }
            };

            return View(cars); // ✅ Передаем список
        }
        
        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Avtorization()
        {
            return View();
        }
        
        public ActionResult Setings()
        {
            return View();
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }
        

    }
}