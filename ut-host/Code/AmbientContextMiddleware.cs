using Contracts;
using Contracts.Interface;
using Contracts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ut_host.Code
{
    public class AmbientContextMiddleware : IMiddleware
    {
        private AppSettings _settings;
        private IUserAuthService _userAuthService;

        public AmbientContextMiddleware(IOptions<AppSettings> options, IUserAuthService userAuthService)
        {
            _settings = options.Value;
            _userAuthService = userAuthService;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var apiSessionId = string.Empty;

            if (context.Request.Path.Value.ToLower().Contains("login") || context.Request.Path.Value.ToLower().Contains("swagger"))
            {
                await next(context);
            }

            else if (context?.Request.Headers.ContainsKey("access-key") == true)
            {
                var accessKey = context.Request.Headers["access-key"];
                if (accessKey.Equals(_settings.AccessKey))
                {
                    await next(context);
                }
                else
                {
                    throw new UnauthorizedAccessException();
                }
            }

            else if (context?.Request.Headers.ContainsKey("session-key") == true)
            {
                apiSessionId = context.Request.Headers["session-key"];

                using (var ambientContext = new AmbientContext(apiSessionId))
                {
                    var userProfile = await _userAuthService.GetSessionInfoAsync(apiSessionId);
                    
                    if (userProfile != null)
                    {
                        ambientContext.UserInfo = userProfile;
                        await next(context);
                    }
                    else
                    {
                        throw new UnauthorizedAccessException();
                    }
                }
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}
