using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataLibrary.DataAccess
{
    public static class SqlDataAccess
    {
        private static readonly string _connectionName = "Server=ServerName;initial catalog=DataBaseName;persist security info=True;user id=UserNameForDatabase;password=passwordIsHere;MultipleActiveResultSets=True;";

        public static int SaveData<T>(string query, T data)
        {
            using (IDbConnection cnn = new SqlConnection(_connectionName))
            {
                return cnn.Execute(query, data);
            }

        }

        public static List<T> LoadData<T>(string query)
        {
            using (IDbConnection cnn = new SqlConnection(_connectionName))
            {
                return cnn.Query<T>(query).ToList();
            }
        }


    }


}
