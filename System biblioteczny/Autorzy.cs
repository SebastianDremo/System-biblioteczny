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
    
    public partial class Autorzy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Autorzy()
        {
            this.Ksiazki = new HashSet<Ksiazki>();
        }
    
        public int autor_id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int kraj_id { get; set; }
    
        public virtual Kraje Kraje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ksiazki> Ksiazki { get; set; }
    }
}
