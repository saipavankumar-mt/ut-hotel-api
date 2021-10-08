using Contracts.Interface;
using Contracts.Models;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLiteDBProvider.Services
{
    public class SQLiteDataService : IDataService
    {
        private DBSettings _settings;

        public SQLiteDataService(IOptions<DBSettings> options)
        {
            _settings = options.Value;
        }

        public async Task<List<T>> GetData<T>(string db, string sqlcommand)
        {
            return await Task.Run(() =>
            {
                var lst = new List<T>();

                using (var client = new SQLiteClient(db))
                {
                    var result = client.RunSelectSQL(sqlcommand);

                    if (result != null)
                    {
                        var parser = result.GetRowParser<T>(typeof(T));

                        while (result.Read())
                        {
                            lst.Add(parser(result));
                        }
                    }
                }

                return lst;
            });
        }


        public async Task<bool> SaveDataSql(string db, string sqlCommand)
        {
            return await Task.Run(() =>
            {
                using (SQLiteClient _client = new SQLiteClient(db))
                {
                    var result = _client.RunInsertOrUpdateOrDeleteSQL(sqlCommand);
                    return true;
                }
            });
        }

        public void SetDataBaseSource(string databaseSource)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDataSql(string tableName, string key, string cmdParams)
        {
            throw new NotImplementedException();
        }
    }
}
