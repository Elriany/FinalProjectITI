//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public course()
        {
            this.std_Crs = new HashSet<std_Crs>();
        }
    
        public int code { get; set; }
        public string crs_Name { get; set; }
        public string crs_AName { get; set; }
        public Nullable<int> levelID { get; set; }
        public Nullable<int> staffId { get; set; }
    
        public virtual ClassLevel ClassLevel { get; set; }
        public virtual staff staff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<std_Crs> std_Crs { get; set; }
    }
}