using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeDAL empdal = new EmployeDAL();
            EmployeeBL empbl = new EmployeeBL(empdal);
            List<Employee> emplist = empbl.GetAllEmployees();
            foreach (var item in emplist)
            {
                Console.WriteLine("ID={0},Name={1},Department={2}",item.ID,item.Name,item.Department);
                Console.WriteLine("\n");
            }
            
            Console.ReadLine();
        }
    }
}
