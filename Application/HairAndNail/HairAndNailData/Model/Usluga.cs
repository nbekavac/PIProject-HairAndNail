//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HairAndNailData.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usluga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usluga()
        {
            this.Racun_sadrzi_usluge = new HashSet<Racun_sadrzi_usluge>();
            this.Termin = new HashSet<Termin>();
        }
    
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Cijena { get; set; }
        public int Vrsta_usluge_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun_sadrzi_usluge> Racun_sadrzi_usluge { get; set; }
        public virtual Vrsta_usluge Vrsta_usluge { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Termin> Termin { get; set; }
    }
}