//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evaluation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evaluation()
        {
            this.GroupEvaluations = new HashSet<GroupEvaluation>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public int TotalWeightage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupEvaluation> GroupEvaluations { get; set; }
    }
}
