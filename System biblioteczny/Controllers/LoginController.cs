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
                var time = new WejsciaOnline()
                {
                    data = DateTime.Now,
                    nr_karty = login.nr_karty
                };

                Uzytkownicy user = context.Uzytkownicy.Where(u => u.nr_karty == login.nr_karty).FirstOrDefault();               

                context.WejsciaOnline.Add(time);               
                context.SaveChanges();

                return View("Logged", user);
            }
            else if (context.Pracownicy.Any(p => p.pracownik_id == login.nr_karty && p.nazwisko == login.haslo))
            {
                return View("AdminView");
            }
            else
                return View("ErrorLogin");
        }
    }
}