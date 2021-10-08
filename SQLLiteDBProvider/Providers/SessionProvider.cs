using Contracts.DBModel;
using Contracts.Interface;
using Contracts.Models;
using Microsoft.Extensions.Options;
using SQLLiteDBProvider.Translator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLiteDBProvider.Providers
{
    public class SessionProvider : ISessionProvider
    {
        private IDataService _dataService;
        private DBSettings _dBSettings;
        public SessionProvider(IDataService dataService, IOptions<DBSettings> options)
        {
            _dataService = dataService;
            _dBSettings = options.Value;
        }

        public async Task<string> CreateSession(string userName)
        {
            var key = Guid.NewGuid().ToString();
            var sqlCmd = string.Format("INSERT INTO {0} {1}", _dBSettings.TableNames.SessionTable, SessionTranslator.ToInsertSqlCmdParams(key, userName));

            var result = await _dataService.SaveDataSql(_dBSettings.DatabaseLocation.UsersDatabase, sqlCmd);

            return result ? key : null;
        }

        public async Task<UserInfo> GetUserInfo(string userName)
        {
            var sqlCmd = string.Format("Select * From {0} where uname = '{1}'", _dBSettings.TableNames.UserTable, userName);

            var result = await _dataService.GetData<UserModel>(_dBSettings.DatabaseLocation.UsersDatabase, sqlCmd);

            return result?.FirstOrDefault().ToCoreModel();
        }



        public async Task<SessionInfo> GetSessionInfo(string key)
        {
            var sqlCmd = string.Format("Select * From {0} where key='{1}'", _dBSettings.TableNames.SessionTable, key);
            var result = await _dataService.GetData<SessionModel>(_dBSettings.DatabaseLocation.UsersDatabase, sqlCmd);

            return result?.FirstOrDefault().ToCoreModel();
        }

        public async Task<PasswordInfo> RetrievePassword(string userName)
        {
            var sqlCmd = string.Format("Select * From {0} where uname='{1}'", _dBSettings.TableNames.PasswordRegistryTable, userName);

            var result = await _dataService.GetData<PasswordModel>(_dBSettings.DatabaseLocation.UsersDatabase, sqlCmd);

            return result?.FirstOrDefault().ToCoreModel();
        }

    }
}