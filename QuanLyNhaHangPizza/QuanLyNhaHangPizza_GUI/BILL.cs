//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhaHangPizza_GUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class BILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BILL()
        {
            this.BILLDETAILs = new HashSet<BILLDETAIL>();
        }
    
        public string ID_Bill { get; set; }
        public string ID_Cus { get; set; }
        public string ID_Emp { get; set; }
        public System.DateTime DateFounded { get; set; }
        public string TotalMoney { get; set; }
        public string BillNotes { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILLDETAIL> BILLDETAILs { get; set; }
    }
}
