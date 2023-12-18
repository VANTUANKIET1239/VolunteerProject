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
        public static Volunteer GetVolunteerByVolunteerID(string volunteerID)
        {
            return VolunteerDAL.GetVolunteerByVolunteerID(volunteerID);
        }
        public static bool UpdateVolunteer(VolunteerDTO volunteerDTO, byte[] img)
        {
            var accountSession = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            bool result = VolunteerDAL.UpdateVolunteer(volunteerDTO,img);
            var account = AccountDAL.GetAccountByID(accountSession.AccountID);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountDTO>());
            var mapper = new Mapper(config);
            AccountDTO dto = mapper.Map<AccountDTO>(account);
            OtherFunction.SessionManager.SetSessionValue("curUser", dto);
            return result;
        }
        public static bool checkEmail(string email)
        {
            return VolunteerDAL.checkEmail(email);
        }
    }
}
