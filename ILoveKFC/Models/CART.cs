//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ILoveKFC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CART
    {
        public string ID_PRODUCT { get; set; }
        public string ID_CUSTOMER { get; set; }
        public string IMAGE_PRODUCT { get; set; }
        public string DESCRIBE { get; set; }
        public string NAME_PRODUCT { get; set; }
        public Nullable<int> COST { get; set; }
        public Nullable<int> QUANTITY_PRODUCT { get; set; }
        public Nullable<int> TOTAL { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}
