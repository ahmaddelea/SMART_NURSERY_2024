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
    
    public partial class VEHICLE_TBL
    {
        public decimal VEHICLE_ID { get; set; }
        public Nullable<decimal> VEHICLE_CODE { get; set; }
        public string VEHICLE_NAME { get; set; }
        public string VEHICLE_NO { get; set; }
        public string VEHICLE_PATH { get; set; }
        public Nullable<decimal> DRIVER_ID { get; set; }
    
        public virtual DRIVER_TBL DRIVER_TBL { get; set; }
    }
}
