using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System_biblioteczny.Models
{
    public class AdminViewModel
    {
        public AdminViewModel(Pracownicy worker, List<Zamowienia> orders)
        {
            this.worker = worker;
            this.orders = orders;
        }

        public Pracownicy worker;
        public List<Zamowienia> orders;
    }
}