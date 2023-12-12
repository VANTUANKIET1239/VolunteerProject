using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.BLL
{
    public class VolunteerBLL
    {
        public static Volunteer GetVolunteer(string accountID)
        {
            return VolunteerDAL.GetVolunteer(accountID);
        }
        public static bool UpdateVolunteer(VolunteerDTO volunteerDTO, byte[] img)
        {
            return VolunteerDAL.UpdateVolunteer(volunteerDTO,img);
        }
    }
}
