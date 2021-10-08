using Contracts.Interface;
using Contracts.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ut_host.Code
{
    public static class ContainerRegistry
    {
        public static void Init(IConfiguration configuration, IServiceCollection services)
        {
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
            services.Configure<DBSettings>(configuration.GetSection("DBSettings"));

            services.AddTransient<AmbientContextMiddleware, AmbientContextMiddleware>();
            services.AddTransient<ExceptionHandler, ExceptionHandler>();

            services.AddTransient<IUserAuthService, UserAuthService.UserAuthService>();

            services.AddTransient<IDataService, SQLLiteDBProvider.Services.SQLiteDataService>();
            services.AddTransient<ISessionProvider, SQLLiteDBProvider.Providers.SessionProvider>();
        }
    }
}
