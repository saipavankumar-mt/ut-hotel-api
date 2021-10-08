using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class SessionResponse
    {
        public string SessionKey { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public Role Role { get; set; }
        public List<string> LinkedHotelIds { get; set; }
    }
}
