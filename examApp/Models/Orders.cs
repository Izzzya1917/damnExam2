//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace examApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public Orders()
        {
            this.SoldItems = new HashSet<SoldItems>();
        }
    
        public int orderId { get; set; }
        public Nullable<int> orderStatusId { get; set; }
        public Nullable<int> orderPlaceId { get; set; }
        public Nullable<System.DateTime> orderDate { get; set; }
        public Nullable<int> orderCode { get; set; }
        public Nullable<int> orderDelievery { get; set; }
        public Nullable<int> orderPrice { get; set; }
    
        public virtual orderGiveaway orderGiveaway { get; set; }
        public virtual orderStatuses orderStatuses { get; set; }
        public virtual ICollection<SoldItems> SoldItems { get; set; }
    }
}
