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
    
    public partial class TemaTabla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TemaTabla()
        {
            this.TemakorFeladatKapcsolo = new HashSet<TemakorFeladatKapcsolo>();
        }
    
        public int Id { get; set; }
        public Nullable<int> TemakorFK { get; set; }
        public string Tema { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemakorFeladatKapcsolo> TemakorFeladatKapcsolo { get; set; }
        public virtual TemakorListaTabla TemakorListaTabla { get; set; }
    }
}