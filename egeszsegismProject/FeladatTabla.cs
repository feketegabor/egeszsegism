//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace egeszsegismProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeladatTabla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FeladatTabla()
        {
            this.TemakorFeladatKapcsolo = new HashSet<TemakorFeladatKapcsolo>();
        }
    
        public int Id { get; set; }
        public string FeladatPdf { get; set; }
        public Nullable<int> Ev { get; set; }
        public string Honap { get; set; }
        public Nullable<int> FeladatSorszama { get; set; }
        public Nullable<int> FeladatTipusFK { get; set; }
        public Nullable<decimal> Szelesseg { get; set; }
        public Nullable<decimal> Magassag { get; set; }
        public byte[] Kep { get; set; }
    
        public virtual FeladatTipusTabla FeladatTipusTabla { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemakorFeladatKapcsolo> TemakorFeladatKapcsolo { get; set; }
        public virtual FeladatMoTabla FeladatMoTabla { get; set; }
    }
}