using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolton.Entities;
using Bolton.Services;
namespace Bolton.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            //App.PrintAllEmployees();


            App.PrintAllEmployees();
        }
    }

    class App
    {
        static EmployeeRepository employeeRepository = new EmployeeRepository();

        public static void PrintAllEmployees()
        {
            var employees = employeeRepository.GetAll().OrderByDescending(x => x.Age);
            Console.WriteLine("{0,-5}{1,-15}{2,-10}{3,-5}", "Id", "Name", "Age", "Salary");

            foreach (var employee in employees)
            {
                Console.WriteLine("{0,-5}{1,-15}{2,-10}{3,-5}", employee.Id, employee.Name, employee.Age, employee.Salary);
            }
        }

        public static void PrintEmployee(int id)
        {
            var employee = employeeRepository.GetById(id);
            Console.WriteLine("{0,-5}{1,-15}{2,-10}{3,-5}", employee.Id, employee.Name, employee.Age, employee.Salary);
        }

        public static int Input()
        {
            Console.WriteLine("Dose mou to id");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
