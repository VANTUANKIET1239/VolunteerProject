using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class VolunteerDAL
    {
        public static Volunteer GetVolunteer(string accountID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            Volunteer volunteer = volunteerDBEntities.Volunteers
                                                        .Where(x => x.AccountID == accountID).FirstOrDefault();
            return volunteer ?? new Volunteer();
        }
        public static bool UpdateVolunteer(VolunteerDTO volunteerDTO, byte[] img)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            Account account = volunteerDBEntities.Accounts.Where(x => x.AccountID == curUser.AccountID).FirstOrDefault();
            Volunteer curVol = volunteerDBEntities.Volunteers.Where(x => x.AccountID == curUser.AccountID).FirstOrDefault();
            account.ImageUS = img;

            curVol.Name = volunteerDTO.Name;
            curVol.Email = volunteerDTO.Email;
            curVol.PhoneNumber = volunteerDTO.PhoneNumber;
            curVol.DistrictId = volunteerDTO.DistrictId;
            curVol.CityId = volunteerDTO.CityId;
            curVol.WardId = volunteerDTO.WardId;
            curVol.BirthDate = volunteerDTO.BirthDate;
            curVol.AddressDetail = volunteerDTO.AddressDetail;
            curVol.Gender = volunteerDTO.Gender;
            curVol.Description = volunteerDTO.Description;
            curVol.PrestigeScore = volunteerDTO.PrestigeScore;
            curVol.RewardPoint = volunteerDTO.RewardPoint;
            curVol.state = volunteerDTO.state;
            curVol.AddressDetail = volunteerDTO.AddressDetail;
            return volunteerDBEntities.SaveChanges()>0;
        }
    }
}
