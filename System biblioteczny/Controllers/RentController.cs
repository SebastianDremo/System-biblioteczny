using System;
using System.Linq;
using System.Web.Mvc;
using System_biblioteczny.Models;

namespace System_biblioteczny.Controllers
{
    public class RentController : Controller
    {        
        [HttpPost]
        public ActionResult ListOfBooks(int card)
        {
            var context = new durbaezgomezEntities1();
            var books = context.Ksiazki.ToList();
            var User = context.Uzytkownicy.First(m => m.nr_karty == card);

            var viewModel = new RentBookViewModel(User, books);
            
            return View(viewModel); 
        }

        [HttpPost]
        public void RentBook(int card, int bookId)
        {
            var context = new durbaezgomezEntities1();       

            var order = new Zamowienia()
            {
                data = DateTime.Now,
                nr_karty = card,
                ksiazka_id = bookId
            };

            context.Zamowienia.Add(order);
            context.SaveChanges();
            //Problem with foreign key - pracownik_id - drop it somehow
        }
    }    
}