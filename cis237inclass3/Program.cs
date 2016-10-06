using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee sEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2014, 10, 31), 537.36m);
            SalaryEmployee sEmployee2 = new SalaryEmployee();
            //Output the SalaryEmployee converted to a string
            Console.WriteLine(sEmployee.ToString());
            Console.WriteLine(sEmployee2.ToString());

            HourlyEmployee hEmployee = new HourlyEmployee("Joe", "Smith", new DateTime(2013, 10, 01), 12.43m, 36m);
            Console.WriteLine(hEmployee.ToString());
            Console.WriteLine(hEmployee.GetYearlySalary());
            Console.WriteLine(hEmployee.GetAllEmployeeInformation());

            //Declare a new collection
            IEmployeeCollection employeeCollection;
            //Instanciate the collection witht he concreate class even though it is going into
            //an interface container
            employeeCollection = new EmployeeCollection();
            //Call the method below to add the employees collection
            AddNewEmployees(employeeCollection);

            //Print the employees out
            PrintEmployees(employeeCollection);

        }

        static void AddNewEmployees(IEmployeeCollection employeeCollection)
        {
            //Add a couple of Salary Employees
            employeeCollection.add("James", "Kirk", new DateTime(2016, 4, 4), 549m);
            employeeCollection.add("Jean-Luc", "Picard", new DateTime(2016, 5, 14), 609m);
            //Add a couple of Hourly Employees
            employeeCollection.add("Benjamein", "Sisko", new DateTime(2016, 4, 4), 49m, 40);
            employeeCollection.add("Hohnathan", "Archer", new DateTime(2016, 4, 4), 54m, 20);
        }

        static void PrintEmployees(IEmployeeCollection employeeCollecton)
        {
            Console.WriteLine(employeeCollecton.GetPrintString());
        }
    }
}
