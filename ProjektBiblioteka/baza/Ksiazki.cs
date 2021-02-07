﻿//------------------------------------------------------------------------------
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
    
    public partial class Ksiazki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ksiazki()
        {
            this.Egzemplarze = new HashSet<Egzemplarze>();
            this.gatunki = new HashSet<gatunki>();
            this.Tworcy = new HashSet<Tworcy>();
        }
    
        public int idKsiazki { get; set; }
        public string tytulKsiazki { get; set; }
        public int rokWydania { get; set; }
        public string rodzajKsiazki { get; set; }
    
        public virtual Cennik Cennik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Egzemplarze> Egzemplarze { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gatunki> gatunki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tworcy> Tworcy { get; set; }

        public override string ToString()
        {
            return $"TYTUŁ: {tytulKsiazki} \nWYDANA: {rokWydania} \nRODZAJ: {rodzajKsiazki}";
        }
    }
}