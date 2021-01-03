using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolton.Entities;
namespace Bolton.Database
{
    public class MyDatabase
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public MyDatabase()
        {
            Employee e1 = new Employee() { Id = 1, Name = "Hector", Salary = 50000, Age = 33 };
            Employee e2 = new Employee() { Id = 2, Name = "Marios", Salary = 30000, Age = 24 };
            Employee e3 = new Employee() { Id = 3, Name = "Vlassis", Salary = 40000, Age = 35 };
            Employee e4 = new Employee() { Id = 4, Name = "Kostas", Salary = 20000, Age = 36 };
            Employees.Add(e1);
            Employees.Add(e2);
            Employees.Add(e3);
            Employees.Add(e4);

        }
    }
}
