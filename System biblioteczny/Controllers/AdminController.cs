using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System_biblioteczny.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpPost]
        public void Rent(string bookId, string cardId, string workerId)
        {
            var context = new durbaezgomezEntities1();
            var from_when = DateTime.Now;
            var to_when = from_when.AddMonths(1);
            

            var rent = new Wypozyczenia()
            {
                ksiazka_id = Int32.Parse(bookId),
                nr_karty = Int32.Parse(cardId),
                pracownik_id = Int32.Parse(workerId),
                od_kiedy = from_when,
                do_kiedy = to_when
            };

            var record = context.Zamowienia.Where(z => z.ksiazka_id == rent.ksiazka_id && z.nr_karty == rent.nr_karty).First();
            context.Zamowienia.Remove(record);

            context.Wypozyczenia.Add(rent);
            context.SaveChanges();
        }
    }
}