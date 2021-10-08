using Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface ISessionProvider
    {
        Task<string> CreateSession(string userName);         
        Task<PasswordInfo> RetrievePassword(string userName);
        Task<UserInfo> GetUserInfo(string userName);

        Task<SessionInfo> GetSessionInfo(string key);
    }
}
