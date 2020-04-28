using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
  public class EmployeeBL
    {
        public IemployeeDAL employeedal;
        public EmployeeBL(IemployeeDAL Imp)
        {
            this.employeedal = Imp;
        }

        public List<Employee> GetAllEmployees()
        {
           return employeedal.SelectAllEmployees();
        }

    }
}
