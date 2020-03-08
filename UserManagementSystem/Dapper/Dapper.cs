using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagementSystem.Dapper
{
    public class Dapper
    {
        IDbConnection GetConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-KAS2TP4;Initial Catalog=UserData;Integrated Security=True");
        }

        public async Task QueryUsers()
        {
            using(IDbConnection connection = GetConnection())
            {
                IEnumerable<User> users = await connection.QueryAsync<User>("SELECT * FROM Users");
            }         
        }
    }
}
