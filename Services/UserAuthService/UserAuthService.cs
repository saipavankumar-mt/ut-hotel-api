using Contracts.Interface;
using Contracts.Models;
using System;
using System.Threading.Tasks;

namespace UserAuthService
{
    public class UserAuthService : IUserAuthService
    {
        private ISessionProvider _sessionProvider;

        public UserAuthService(ISessionProvider sessionProvider)
        {
            _sessionProvider = sessionProvider;
        }

        public async Task<UserInfo> GetSessionInfoAsync(string sessionKey)
        {
            var sessionInfo = await _sessionProvider.GetSessionInfo(sessionKey);
            if (sessionInfo != null)
            {
                return await _sessionProvider.GetUserInfo(sessionInfo.UserName);
            }

            return null;
        }

        public async Task<SessionResponse> UserSignInAsync(SignInRequest request)
        {
            var passwordInfo = await _sessionProvider.RetrievePassword(request.UserName);
            if (passwordInfo != null && passwordInfo.Password.Equals(request.Password))
            {
                var user = await _sessionProvider.GetUserInfo(request.UserName);

                if (user != null)
                {
                    var key = await _sessionProvider.CreateSession(request.UserName);

                    return new SessionResponse()
                    {
                        SessionKey = key,
                        UserName = user.UserName,
                        UserFullName = user.FullName,
                        Role = user.Role,
                        LinkedHotelIds = user.LinkedHotelIds
                    };
                }
            }

            throw new Exception("Incorrect username or password");
        }
    }
}
