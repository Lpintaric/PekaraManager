//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PekaraData
{
    using System;
    using System.Collections.Generic;
    
    public partial class NarudzbaProdaje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NarudzbaProdaje()
        {
            this.Stavka_narudzbeProdaje = new HashSet<Stavka_narudzbeProdaje>();
        }
    
        public int ID_narudzbeProdaje { get; set; }
        public Nullable<int> ID_zaposlenika { get; set; }
        public Nullable<int> ID_kupca { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<double> Iznos { get; set; }
    
        public virtual Kupac Kupac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_narudzbeProdaje> Stavka_narudzbeProdaje { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
