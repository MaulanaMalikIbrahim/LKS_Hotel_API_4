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
    
    public partial class room_view
    {
        public int id { get; set; }
        public int roomTypeId { get; set; }
        public int roomNumber { get; set; }
        public int roomFloor { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public int capacity { get; set; }
        public int roomPrice { get; set; }
    }
}