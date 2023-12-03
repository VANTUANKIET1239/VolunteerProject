//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VolunProject.Data.EntityADO.NET
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public Event()
        {
            this.Registrations = new HashSet<Registration>();
        }
    
        public string EventID { get; set; }
        public string EventName { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> WardId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Status { get; set; }
        public string CategoryId { get; set; }
        public Nullable<bool> state { get; set; }
    
        public virtual EventCategory EventCategory { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
