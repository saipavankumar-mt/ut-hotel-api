using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public List<string> LinkedHotelIds { get; set; }
    }
}
