//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMART_NURSERT_DATABASE_2024
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEGREE_TBL
    {
        public decimal DEGREE_ID { get; set; }
        public Nullable<decimal> DEGREE_CODE { get; set; }
        public decimal EVAL_ID { get; set; }
    
        public virtual EVALUATION_TBL EVALUATION_TBL { get; set; }
    }
}
