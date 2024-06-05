using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMVP.Models
{
    public interface IEmployeeRepository
    {
        void Add(EmployeeModel employeeModel);
        void Update(EmployeeModel employeeModel);
        void Delete(int id);
        IEnumerable<EmployeeModel> GetAll();
        IEnumerable<EmployeeModel> GetByValue(string value);
    }
}
