using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connecionString)
        {
            using (IDbConnection connection = new MySqlConnection(connecionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);
                return rows.ToList();
            }
        }

        public Task SaveData<T>(string sql, T parameters, string connecionString)
        {
            using (IDbConnection connection = new MySqlConnection())
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
 