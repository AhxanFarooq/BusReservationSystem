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
    
    public partial class TicketDetail
    {
        public int Id { get; set; }
        public Nullable<int> custId { get; set; }
        public Nullable<System.DateTime> dateOfTicket { get; set; }
        public string seatNo { get; set; }
        public Nullable<int> BusId { get; set; }
    }
}
