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
    
    public partial class Racun_sadrzi_usluge
    {
        public int Usluga_id { get; set; }
        public int Racun_id { get; set; }
        public Nullable<int> Kolicina { get; set; }
    
        public virtual Racun Racun { get; set; }
        public virtual Usluga Usluga { get; set; }
    }
}
