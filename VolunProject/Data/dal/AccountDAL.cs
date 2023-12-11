using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

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
                account.ImageUS = OtherFunction.PathImage2Byte("C:\\Users\\LENOVO\\Desktop\\Git\\VolunteerProject\\VolunProject\\Resources\\user-default.png");
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
                    return true;
                }
            }
            return false;
        }
    }
}
