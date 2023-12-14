using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VolunProject.Data.DAL
{
    public  class AccountDAL
    {
        public AccountDAL() {
        }

        public static bool checkAccountName(string accountName)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            if (volunteerDBEntities.Accounts.Where(x => x.AccountName == accountName).Any()) return true;
            return false;
        }
        public  static bool SignUp(AccountDTO accountDTO)
        {         
            if (accountDTO != null)
            {
                VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
                int allUserCount = volunteerDBEntities.Accounts.Where(x => x.state == true).Count();
                string newAccountID = "ACC" + (allUserCount + 1).ToString("0000000");
                Account account = new Account();
                account.AccountID = newAccountID;
                account.AccountName = accountDTO.AccountName;
                account.Password = accountDTO.Password;
                account.CreateDate = DateTime.Now;
                account.state = true;
                account.ImageUS = OtherFunction.PathImage2Byte("C:\\Users\\PC\\Desktop\\Propro\\VolunProject\\VolunProject\\Resources\\user-default.png");
                account.RoleName = "VOLUNTEER";

                volunteerDBEntities.Accounts.Add(account);
                if (volunteerDBEntities.SaveChanges() > 0)
                {
                    var accountUser = volunteerDBEntities.Accounts.Where(x => x.AccountID == newAccountID).FirstOrDefault();
                    int allVolunteerCount = volunteerDBEntities.Volunteers.Where(x => x.state == true).Count();
                    Volunteer volunteer = new Volunteer();
                    volunteer.VolunteerID = "VOL" + (allVolunteerCount + 1).ToString("0000000");
                    volunteer.AccountID = newAccountID;
                    volunteer.Email = "";
                    volunteer.PhoneNumber = "";
                    volunteer.Name = "";
                    volunteer.Account = accountUser;
                    volunteer.state = true;
                    volunteer.Description = "";
                    volunteer.PrestigeScore = 0;
                    volunteer.RewardPoint = 0;
                    volunteerDBEntities.Volunteers.Add(volunteer);

                    volunteerDBEntities.Volunteers.Include(x => x.Account);
                    return volunteerDBEntities.SaveChanges() > 0;
                }                        
            }
            return false;
        }

        public static bool LogIn(string userName, string passWord)
        {         
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var currentUser =  volunteerDBEntities.Accounts.Where(x => x.AccountName == userName.Trim()).FirstOrDefault();
            if (currentUser != null)
            {
                if (currentUser.Password == passWord)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountDTO>());
                    var mapper = new Mapper(config);
                    AccountDTO dto = mapper.Map<AccountDTO>(currentUser);
                    OtherFunction.SessionManager.SetSessionValue("curUser", dto);
                    return true;
                }
            }
            return false;
        }
        public static bool changePassword(string accountName, string password)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var currentUser = volunteerDBEntities.Accounts.Where(x => x.AccountName == accountName.Trim()).FirstOrDefault();
            currentUser.Password = password;
            return volunteerDBEntities.SaveChanges() > 0;
        }
    }
}
