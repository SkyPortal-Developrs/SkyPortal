using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
        public interface IemployeeDAL
        {
             List<Employee> SelectAllEmployees();
        }

    public class EmployeDAL :IemployeeDAL
    {

        public List<Employee> SelectAllEmployees()
        {
            List<Employee> Employeelist = new List<Employee>();
            Employeelist.Add(new Employee() { ID = 1, Name = "Rainy", Department = "CSE" });
            Employeelist.Add(new Employee() { ID = 2, Name = "tom", Department = "ECE" });
            Employeelist.Add(new Employee() { ID = 3, Name = "Steve", Department = "MECH" });
            return Employeelist;
        }

    }
}
