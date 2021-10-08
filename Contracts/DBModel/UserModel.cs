using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.DBModel
{
    public class UserModel
    {
        public string uid { get; set; }
        public string uname { get; set; }
        public string ufname { get; set; }
        public string phnumber { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string hids { get; set; }
    }
}
