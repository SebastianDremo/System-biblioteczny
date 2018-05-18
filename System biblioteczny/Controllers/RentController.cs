using System.Web.Mvc;

namespace System_biblioteczny.Controllers
{
    public class RentController : Controller
    {        
        [HttpPost]
        public ActionResult RentBook(Uzytkownicy User)
        {
            return View("ListOfBooks", User);
        }
    }
}