//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class doChoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doChoi()
        {
            this.thanhToans = new HashSet<thanhToan>();
        }
    
        public int Ma_sp { get; set; }
        public string Ten_sp { get; set; }
        public string Nsx { get; set; }
        public Nullable<int> Don_gia { get; set; }
        public string Loai_do_choi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thanhToan> thanhToans { get; set; }
    }
}