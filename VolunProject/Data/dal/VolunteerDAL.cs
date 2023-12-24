using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;
using VolunProject.UserInterface.CheckIn_CheckOut;

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
        public static Volunteer GetVolunteerByVolunteerID(string volunteerID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            Volunteer volunteer = volunteerDBEntities.Volunteers
                                                        .Where(x => x.VolunteerID == volunteerID).FirstOrDefault();
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
            curVol.status = true;
            curVol.AddressDetail = volunteerDTO.AddressDetail;
            return volunteerDBEntities.SaveChanges()>0;
        }
        public static bool checkEmail(string email)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Volunteers.Any(x => x.Email == email);
        }
        public static bool checkEmail_Information(string volunteerID, string email)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Volunteers.Any(x =>  x.VolunteerID != volunteerID && x.Email == email );
        }
        public static ICollection<RegistrationVolunteerDTO> Volunteer_ByEventID(string eventID, VolunteerSearchDTO volunteerSearchDTO )
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Registrations
                .Include(x => x.Volunteer)
                .Where(x => x.EventID == eventID && x.state == true && x.status == "A")
                .Select(x => new RegistrationVolunteerDTO()
                {
                    VolunteerID = x.VolunteerID,
                    Name = x.Volunteer.Name,
                    
                    Email = x.Volunteer.Email,
                    PhoneNumber = x.Volunteer.PhoneNumber,
                    DistrictId = x.Volunteer.DistrictId ?? 0,
                    CityId = x.Volunteer.CityId ?? 0,
                    WardId = x.Volunteer.WardId ?? 0,
                    AccountID = x.Volunteer.AccountID,
                    Gender = x.Volunteer.Gender ?? true,
                    status = x.status,
                    CheckIn = x.CheckIn,
                    CheckOut = x.CheckOut,
                    CheckInDate = x.CheckInDate,
                    CheckOutDate = x.CheckOutDate,
                    AddressDetail = x.Volunteer.AddressDetail,
                    EventID = x.EventID
                })
                .Where(x => x.CheckIn == volunteerSearchDTO.CheckIn || volunteerSearchDTO.CheckIn == null)
                 .Where(x => x.CheckOut == volunteerSearchDTO.CheckOut || volunteerSearchDTO.CheckOut == null)
                   .Where(x => x.Name == volunteerSearchDTO.Name.Trim() || volunteerSearchDTO.Name.Trim() == "" || volunteerSearchDTO.Name == null)
                .ToList();
        }
        public static bool updatePoint(string volunteerID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var volunteer = volunteerDBEntities.Volunteers.Where(x => x.VolunteerID == volunteerID).FirstOrDefault();
            if (volunteer.RankId == "Silver")
            {
                volunteer.RewardPoint += 550;
                volunteer.PrestigeScore += 550;
            }
            else if (volunteer.RankId == "Gold")
            {
                volunteer.RewardPoint += 600;
                volunteer.PrestigeScore += 600;
            }
            else if (volunteer.RankId == "Diamond")
            {
                volunteer.RewardPoint += 800;
                volunteer.PrestigeScore += 800;
            }
            else
            {
                volunteer.RewardPoint += 500;
                volunteer.PrestigeScore += 500;
            }
            if(volunteer.PrestigeScore >= 2000) volunteer.RankId = "Diamond";
            else if(volunteer.PrestigeScore >= 1000) volunteer.RankId = "Gold";
            else if(volunteer.PrestigeScore >= 500) volunteer.RankId = "Silver";
            return volunteerDBEntities.SaveChanges() > 0;
        }
    }
}
