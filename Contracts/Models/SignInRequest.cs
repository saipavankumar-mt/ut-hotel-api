using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class SignInRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
