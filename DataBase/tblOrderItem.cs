//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrderItem
    {
        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public int qty { get; set; }
        public int OrderID { get; set; }
    
        public virtual tblOrder tblOrder { get; set; }
        public virtual tblProduct tblProduct { get; set; }
    }
}