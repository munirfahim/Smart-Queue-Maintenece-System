//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int BID { get; set; }
        public int Token { get; set; }
        public string BookingDetails { get; set; }
        public int TimeRequired { get; set; }
        public int UID { get; set; }
        public int EID { get; set; }
        public string Status { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
    }
}
