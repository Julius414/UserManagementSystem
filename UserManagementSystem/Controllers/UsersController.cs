using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UserManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            //return QueryUsers();

            return QueryUsers().GetAwaiter().GetResult();
        }

        IDbConnection GetConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-KAS2TP4;Initial Catalog=UserData;Integrated Security=True");
        }

        public async Task<IEnumerable<User>> QueryUsers()
        {
            using (IDbConnection connection = GetConnection())
            {
                IEnumerable<User> users = await connection.QueryAsync<User>("SELECT * FROM Users");

                return users;
            }        
        }
    }
}
