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
    
    public partial class PostLike
    {
        public string VolunteerID { get; set; }
        public string PostID { get; set; }
        public Nullable<bool> state { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}
