using Contracts.DBModel;
using Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLLiteDBProvider.Translator
{
    public static class SessionTranslator
    {
        public static PasswordInfo ToCoreModel(this PasswordModel passwordModel)
        {
            return new PasswordInfo()
            {
                UserName = passwordModel?.uname,
                Password = passwordModel?.pwd
            };
        }
        public static UserInfo ToCoreModel(this UserModel userModel)
        {
            return new UserInfo()
            {
                Id = userModel?.uid,
                UserName = userModel?.uname,
                FullName = userModel?.ufname,
                PhoneNumber = userModel?.phnumber,
                Email = userModel?.email,
                Role = Enum.Parse<Role>(userModel?.role),
                Address = userModel?.address,
                City = userModel?.city,
                State = userModel?.state,
                Country = userModel?.country,
                LinkedHotelIds = userModel?.hids?.Split(',')?.ToList(),
            };
        }

        public static SessionInfo ToCoreModel(this SessionModel sessionModel)
        {
            return new SessionInfo()
            {
                SessionKey = sessionModel?.key,
                UserName = sessionModel?.uname,
                CreatedOn = sessionModel?.createdon
            };
        }

        public static string ToInsertSqlCmdParams(string key, string userName)
        {
            string sqlCmd = string.Format("(key, uname, createdon) VALUES ('{0}', '{1}', '{2}')", key, userName, DateTime.Now.ToString());

            return sqlCmd;
        }
    }
}
