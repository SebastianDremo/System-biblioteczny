using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System_biblioteczny.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckForLogin(Loginy login)
        {
            var context = new durbaezgomezEntities1();

            if (context.Loginy.Any(o => o.nr_karty == login.nr_karty && o.haslo == login.haslo))
            {
                return View("Logged", login);
            }
            else return View("Error");
        }
    }
}