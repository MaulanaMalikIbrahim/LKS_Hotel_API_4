//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKS_Hotel_API_4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reservation()
        {
            this.reservationRooms = new HashSet<reservationRoom>();
        }
    
        public int id { get; set; }
        public System.DateTime datetime { get; set; }
        public int employeeId { get; set; }
        public int customerId { get; set; }
        public string bookingCode { get; set; }
        public string month { get; set; }
        public string year { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual employee employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservationRoom> reservationRooms { get; set; }
    }
}