//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XATTACKModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ATTACKSURFACE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ATTACKSURFACE()
        {
            this.ATTACKSURFACEFORATTACKPATTERN = new HashSet<ATTACKSURFACEFORATTACKPATTERN>();
            this.ATTACKSURFACELOCALITYFORATTACKSURFACE = new HashSet<ATTACKSURFACELOCALITYFORATTACKSURFACE>();
            this.ATTACKSURFACESERVICE = new HashSet<ATTACKSURFACESERVICE>();
            this.ATTACKSURFACETYPEFORATTACKSURFACE = new HashSet<ATTACKSURFACETYPEFORATTACKSURFACE>();
        }
    
        public int AttackSurfaceID { get; set; }
        public string AttackSurfaceGUID { get; set; }
        public string AttackSurfaceName { get; set; }
        public string AttackSurfaceDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> ConfidenceReasonID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKSURFACEFORATTACKPATTERN> ATTACKSURFACEFORATTACKPATTERN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKSURFACELOCALITYFORATTACKSURFACE> ATTACKSURFACELOCALITYFORATTACKSURFACE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKSURFACESERVICE> ATTACKSURFACESERVICE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKSURFACETYPEFORATTACKSURFACE> ATTACKSURFACETYPEFORATTACKSURFACE { get; set; }
    }
}
