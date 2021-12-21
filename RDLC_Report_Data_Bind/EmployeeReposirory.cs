using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace RDLC_Report_Data_Bind
{
    public class EmployeeReposirory : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeReposirory(IOptions<AppDbConnection> config) {
            _connectionString = config.Value.ConnectionString;
        }
        public async Task<IEnumerable<employeedata>> GetEmployeedatas()
        {
            using (IDbConnection db = new SqlConnection(_connectionString)) {
                return await db.QueryAsync<employeedata>("select * from employeedata", commandType: CommandType.Text);
            }
        }
    }
}
