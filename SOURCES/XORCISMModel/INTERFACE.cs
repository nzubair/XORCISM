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
    
    public partial class INTERFACE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INTERFACE()
        {
            this.SYSTEMINFO = new HashSet<SYSTEMINFO>();
        }
    
        public int InterfaceID { get; set; }
        public string InterfaceName { get; set; }
        public string ipaddressIPv4 { get; set; }
        public string ipaddressIPv6 { get; set; }
        public string MacAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTEMINFO> SYSTEMINFO { get; set; }
    }
}
