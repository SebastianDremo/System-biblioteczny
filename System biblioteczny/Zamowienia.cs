//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System_biblioteczny
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zamowienia
    {
        public int zamowienie_id { get; set; }
        public System.DateTime data { get; set; }
        public int nr_karty { get; set; }
        public int ksiazka_id { get; set; }
    
        public virtual Ksiazki Ksiazki { get; set; }
        public virtual Uzytkownicy Uzytkownicy { get; set; }
    }
}
