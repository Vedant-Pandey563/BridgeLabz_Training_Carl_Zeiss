using Microsoft.Data.SqlClient;
using System.Data;
namespace StudentApi.Data
{
    public class DapperContext
    {
        private readonly IConfiguration _config;
        private readonly string _connectionstring;

        public DapperContext(IConfiguration config)
        {
            _config = config;
            _connectionstring = _config.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()=> new SqlConnection(_connectionstring);

    }
}
