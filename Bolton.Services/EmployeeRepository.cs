using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolton.Entities;
using Bolton.Database;

namespace Bolton.Services
{
    public class EmployeeRepository
    {
        MyDatabase db = new MyDatabase();

        //GetAll
        public List<Employee> GetAll()
        {
            return db.Employees;
        }

        //GetById
        public Employee GetById(int id)
        {
           return db.Employees.Find(x => x.Id == id);
        }

        //Insert


        //Update

        //Delete
    }
}
