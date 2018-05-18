using System.Linq;
using System.Web.Mvc;
using System_biblioteczny.Models;

namespace System_biblioteczny.Controllers
{
    public class RentController : Controller
    {        
        [HttpPost]
        public ActionResult RentBook(Uzytkownicy User)
        {
            var context = new durbaezgomezEntities1();
            var books = context.Ksiazki.ToList();

            var viewModel = new RentBookViewModel(User, books);
            
            return View("ListOfBooks", viewModel);
        }
    }
}