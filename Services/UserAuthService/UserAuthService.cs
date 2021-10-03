using Contracts.Interface;
using Contracts.Models;
using System;
using System.Threading.Tasks;

namespace UserAuthService
{
    public class UserAuthService : IUserAuthService
    {
        public async Task<string> UserSignInAsync(SignInRequest request)
        {
            return await Task.Run(() => Guid.NewGuid().ToString());
        }
    }
}
