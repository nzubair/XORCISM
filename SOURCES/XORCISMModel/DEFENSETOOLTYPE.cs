//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEFENSETOOLTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEFENSETOOLTYPE()
        {
            this.OWASPTOP10 = new HashSet<OWASPTOP10>();
        }
    
        public int DefenseToolTypeID { get; set; }
        public string DefenseToolTypeName { get; set; }
        public string DefenseToolTypeDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OWASPTOP10> OWASPTOP10 { get; set; }
    }
}
