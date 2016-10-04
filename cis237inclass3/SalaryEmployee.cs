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

        public override string ToString()
        {
            //Take the string the parent's(base) ToString will retuen, and concat the weeklySalary to it.
            //Must use thekeyword base if trying to access the parents version of the method.
            return base.ToString() + " " + this._weeklySalary;
        }

        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this._weeklySalary;
        }

        //Override the abstract method in the Employee class. Because the Employee class declares the
        //method as abstract, this class MUST implement it.
        public override decimal GetYearlySalary()
        {
            return this._weeklySalary * 52;
        }

        //Constructor
        public SalaryEmployee(string FirstName, string LastName, DateTime StartDate, decimal WeeklySalary) 
            //This next part calls the parent classes constructor so that we don't hae to repeat the work
            // that the parent constructor is doing-----Note the line below is a contiuation of the line above----
            : base(FirstName, LastName, StartDate)
        {
            _weeklySalary = WeeklySalary;
        }

        public SalaryEmployee() : base() { }  // make a base constructor that is a copy of the base constructor
    }
}
