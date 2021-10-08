using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IDataService
    {
        void SetDataBaseSource(string databaseSource);

        Task<List<T>> GetData<T>(string db, string sqlcommand);

        Task<bool> SaveDataSql(string db, string sqlCommand);

        Task<bool> UpdateDataSql(string tableName, string key, string cmdParams);

    }
}
