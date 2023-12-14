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
    public class AccountBLL
    {
        public static bool SignUp(AccountDTO accountDTO)
        {
            return AccountDAL.SignUp(accountDTO);
        }
        public static bool checkAccountName(string accountName)
        {
            return AccountDAL.checkAccountName(accountName);
        }
        public static bool LogIn(string userName, string passWord)
        {
            return AccountDAL.LogIn(userName,passWord);
        }
        public static bool changePassword(string accountName, string password)
        {
            return AccountDAL.changePassword(accountName,password);
        }
        public static Account GetAccountByID(string accountID)
        {
            return AccountDAL.GetAccountByID(accountID);
        }
    }
}
