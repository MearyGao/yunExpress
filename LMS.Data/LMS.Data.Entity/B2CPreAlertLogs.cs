//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class B2CPreAlertLogs : Entity
    {
        public virtual string WayBillNumber { get; set; }
        public virtual string ShippingMethod { get; set; }
        public virtual Nullable<int> PreAlertID { get; set; }
        public virtual string ErrorMsg { get; set; }
        public virtual Nullable<int> ErrorCode { get; set; }
        public virtual string ErrorDetails { get; set; }
        public virtual int Status { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual string PreAlertBatchNo { get; set; }
    }
}