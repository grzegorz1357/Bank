﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administratorzy> Administratorzy { get; set; }
        public virtual DbSet<Blokady> Blokady { get; set; }
        public virtual DbSet<Historia_miedzybankowa> Historia_miedzybankowa { get; set; }
        public virtual DbSet<Historia_status> Historia_status { get; set; }
        public virtual DbSet<Historia_wewnatrzbankowa> Historia_wewnatrzbankowa { get; set; }
        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<Odbiorcy_zdefiniowani> Odbiorcy_zdefiniowani { get; set; }
        public virtual DbSet<Przelew_cykliczny> Przelew_cykliczny { get; set; }
        public virtual DbSet<Rachunki> Rachunki { get; set; }
        public virtual DbSet<Rachunki_rodzaj> Rachunki_rodzaj { get; set; }
    }
}
