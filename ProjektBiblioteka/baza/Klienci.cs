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
    
    public partial class Klienci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klienci()
        {
            this.Wypozyczenia = new HashSet<Wypozyczenia>();
        }
    
        public int idKlienta { get; set; }
        public string NrDowodu { get; set; }
        public string nazwiskoKlienta { get; set; }
        public string imieKlienta { get; set; }
        public string plec { get; set; }
        public Nullable<System.DateTime> dataUrodzenia { get; set; }
        public string ulica { get; set; }
        public string kodPocztowy { get; set; }
        public string Miejscowosc { get; set; }
        public Nullable<System.DateTime> dataWprowadzenia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wypozyczenia> Wypozyczenia { get; set; }

        public override string ToString()
        {
            return $"Id: {idKlienta} \n Name: {imieKlienta} {nazwiskoKlienta} Id card: {NrDowodu} City: {Miejscowosc}";
        }
    }
}
