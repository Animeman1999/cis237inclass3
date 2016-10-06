using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class EmployeeCollection : IEmployeeCollection
    {
        //I can instanciate this array as an Employee type because it is an array.
        //Evan though I can's instanciate a singel Employee since it is abstract, and array
        //is fine. I just have to make sure that I put non-abstract instances into it.
        IEmployee[] employees = new Employee[10];

        int currentIndex;

        //Constructor

        public EmployeeCollection()
        {
            currentIndex = 0;
        }
        public void add(string FirstName, string LastName, DateTime StartDate, decimal Salary)
        {
            employees[currentIndex++] = new SalaryEmployee(FirstName, LastName, StartDate, Salary);
        }

        public void add(string FirstName, string LastName, DateTime StartDate, decimal HourlyRate, decimal HoursPerWeek)
        {
            employees[currentIndex++] = new HourlyEmployee(FirstName, LastName, StartDate, HourlyRate, HoursPerWeek);
        }

        public string GetPrintString()
        {
            //declare a blank string to start
            string allOutput = "";

            //For each employee in the collection
            foreach (Employee employee in employees)
            {
                //So long as the employee is not null
                if (employee != null)
                {
                    //Concat the employee information
                    allOutput += employee.ToString() + Environment.NewLine;


                    //Right int the Danger Zone!!!! Because you don't know if it is the right employee (SalaryEmploye instead of HourlyEmployee)
                    //Otherwise calling NameAndSalary method would fail since not in the HourlyEmployee class.
                    
                    if (employee.GetType() == typeof(SalaryEmployee))
                    {
                        //--- This is called down casting because we are down casting it form
                        //the type of Employee down to the type of SalaryEmployee
                        allOutput += ((SalaryEmployee)employee).NameAndSalary() + Environment.NewLine;
                    }
                    
                    
                }
            }
            //Return the concated string
            return allOutput;
        }
    }
}
