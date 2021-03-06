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
    
    public partial class SenderInfo : Entity
    {
    
        ICollection<CustomerOrderInfo> _customerOrderInfos;
        ICollection<WayBillInfo> _wayBillInfos;
    
    
        public virtual int SenderInfoID { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual string SenderFirstName { get; set; }
        public virtual string SenderLastName { get; set; }
        public virtual string SenderCompany { get; set; }
        public virtual string SenderAddress { get; set; }
        public virtual string SenderCity { get; set; }
        public virtual string SenderState { get; set; }
        public virtual string SenderZip { get; set; }
        public virtual string SenderPhone { get; set; }
    
        public virtual ICollection<CustomerOrderInfo> CustomerOrderInfos 
    	{
            get { return _customerOrderInfos  ?? (_customerOrderInfos  = new List<CustomerOrderInfo>()); }
            protected set { _customerOrderInfos  = value; }
        }
    
        public virtual ICollection<WayBillInfo> WayBillInfos 
    	{
            get { return _wayBillInfos  ?? (_wayBillInfos  = new List<WayBillInfo>()); }
            protected set { _wayBillInfos  = value; }
        }
    
    }
}
