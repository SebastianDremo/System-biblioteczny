using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System_biblioteczny.Models
{
    public class RentBookViewModel
    {
        public RentBookViewModel(Uzytkownicy user, List<Ksiazki> books)
        {
            this.User = user;
            this.Books = books;
        }

        public Uzytkownicy User;
        public List<Ksiazki> Books;
    }
}