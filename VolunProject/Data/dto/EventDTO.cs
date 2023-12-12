using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class EventDTO
    {
        public string EventID { get; set; }
        public string EventName { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int WardId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string CategoryId { get; set; }
        public bool state { get; set; }
        public string description { get; set; }
        public string purpose { get; set; }
        public string time { get; set; }
        public byte[] EventImage { get; set; }
    }
}
