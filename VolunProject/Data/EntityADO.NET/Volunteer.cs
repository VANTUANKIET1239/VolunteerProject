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
    
    public partial class Volunteer
    {
        public Volunteer()
        {
            this.Comments = new HashSet<Comment>();
            this.Posts = new HashSet<Post>();
            this.Registrations = new HashSet<Registration>();
            this.Reviews = new HashSet<Review>();
            this.ReviewLists = new HashSet<ReviewList>();
            this.VolunteerLikeEvents = new HashSet<VolunteerLikeEvent>();
            this.VolunteerRewards = new HashSet<VolunteerReward>();
        }
    
        public string VolunteerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> WardId { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string AccountID { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Description { get; set; }
        public Nullable<int> PrestigeScore { get; set; }
        public Nullable<int> RewardPoint { get; set; }
        public Nullable<bool> state { get; set; }
        public string AddressDetail { get; set; }
        public string RankId { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual Ranking Ranking { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<ReviewList> ReviewLists { get; set; }
        public virtual ICollection<VolunteerLikeEvent> VolunteerLikeEvents { get; set; }
        public virtual ICollection<VolunteerReward> VolunteerRewards { get; set; }
    }
}
