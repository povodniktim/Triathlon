using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connecionString);
        Task SaveData<T>(string sql, T parameters, string connecionString);
    }
}