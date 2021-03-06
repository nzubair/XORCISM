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
    
    public partial class AUDITFINDING
    {
        public int AuditFindingID { get; set; }
        public int AuditID { get; set; }
        public int FindingID { get; set; }
        public Nullable<int> AuditProcedureID { get; set; }
        public string AuditFindingName { get; set; }
        public string AuditFindingDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        public virtual AUDIT AUDIT { get; set; }
        public virtual AUDITPROCEDURE AUDITPROCEDURE { get; set; }
        public virtual FINDING FINDING { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
