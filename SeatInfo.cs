//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusReservationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeatInfo
    {
        public int Id { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public Nullable<int> BusId { get; set; }
        public Nullable<int> seatNo { get; set; }
        public Nullable<int> custId { get; set; }
    }
}
