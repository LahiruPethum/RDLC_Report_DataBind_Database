using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDLC_Report_Data_Bind
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<employeedata>> GetEmployeedatas();
    }
}
