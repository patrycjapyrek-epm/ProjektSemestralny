//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektBiblioteka.baza
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wypozyczenia
    {
        public int idWypozyczenia { get; set; }
        public int idEgzemplarza { get; set; }
        public int idKlienta { get; set; }
        public System.DateTime dataWypozyczenia { get; set; }
        public Nullable<decimal> oplataZa7Dni { get; set; }
        public Nullable<System.DateTime> dataZwrotu { get; set; }
    
        public virtual Doplaty Doplaty { get; set; }
        public virtual Egzemplarze Egzemplarze { get; set; }
        public virtual Klienci Klienci { get; set; }

        public override string ToString()
        {
            return $"Order id: {idWypozyczenia} Book(example) id: {idEgzemplarza} Client id: {idKlienta}";
        }
    }
}