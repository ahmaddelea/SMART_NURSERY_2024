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
    
    public partial class DRIVER_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DRIVER_TBL()
        {
            this.VEHICLE_TBL = new HashSet<VEHICLE_TBL>();
        }
    
        public decimal DRIVER_ID { get; set; }
        public Nullable<decimal> DRIVER_CODE { get; set; }
        public string DRIVER_NAME { get; set; }
        public Nullable<decimal> EMP_ID { get; set; }
    
        public virtual EMPLOYEE_TBL EMPLOYEE_TBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEHICLE_TBL> VEHICLE_TBL { get; set; }
    }
}
