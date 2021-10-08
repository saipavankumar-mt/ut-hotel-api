using Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IUserAuthService
    {
        Task<SessionResponse> UserSignInAsync(SignInRequest request);

        Task<UserInfo> GetSessionInfoAsync(string sessionKey);
    }
}
