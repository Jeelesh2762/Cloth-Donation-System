//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClothDonationApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donation
    {
        public int DonationId { get; set; }
        public int UserId { get; set; }
        public string City { get; set; }
        public string ContentSize { get; set; }
        public string Status { get; set; }
        public string DonarName { get; set; }
        public decimal Mobile { get; set; }
    
        public virtual User User { get; set; }
    }
}
