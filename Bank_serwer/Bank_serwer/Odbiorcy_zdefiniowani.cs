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
    
    public partial class Odbiorcy_zdefiniowani
    {
        public int id_odbiorcy_zdefiniowani { get; set; }
        public int id_wlasciciela { get; set; }
        public string nr_rachunku { get; set; }
        public string nazwa { get; set; }
        public string adres { get; set; }
    
        public virtual Klienci Klienci { get; set; }
    }
}
