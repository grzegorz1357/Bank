//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank_serwer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Administratorzy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Administratorzy()
        {
            this.Blokady = new HashSet<Blokady>();
        }
    
        public int id_administratora { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string pesel { get; set; }
        public string nr_dowodu { get; set; }
        public string miasto { get; set; }
        public string ulica { get; set; }
        public string nr_domu { get; set; }
        public string nr_mieszkania { get; set; }
        public string login { get; set; }
        public string haslo { get; set; }
        public string nr_telefonu { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blokady> Blokady { get; set; }
    }
}
