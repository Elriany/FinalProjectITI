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
    
    public partial class parent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public parent()
        {
            this.students = new HashSet<student>();
        }
    
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string Afname { get; set; }
        public string Alname { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Img { get; set; }
        public Nullable<bool> status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student> students { get; set; }
    }
}
