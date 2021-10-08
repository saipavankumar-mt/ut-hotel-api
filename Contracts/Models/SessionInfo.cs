using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class SessionInfo
    {
        public string SessionKey { get; set; }
        public string UserName { get; set; }
        public string CreatedOn { get; set; }
    }
}
