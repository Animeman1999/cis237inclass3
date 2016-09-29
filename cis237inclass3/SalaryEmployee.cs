using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
        //Variables
        private decimal _weeklySalary;

        //Properties
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = WeeklySalary; }
        }
        //Methods
        public String NameAndSalary()
        {
            return base.ToString() + " " + _weeklySalary.ToString("C");
        }

        //Constructor
        public SalaryEmployee(string FirstName, string LastName, DateTime StartDate, decimal WeeklySalary) 
            //This next part calls the parent classes constructor so that we don't hae to repeat the work
            // that the parent constructor is doing-----Note the line below is a contiuation of the line above----
            : base(FirstName, LastName, StartDate)
        {
            _weeklySalary = WeeklySalary;
        }

        public SalaryEmployee() : base() { }  // make abase constructor that is a copy of the base constructor
    }
}
