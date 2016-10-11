using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class HourlyEmployee : Employee
    {
        //Variable for this class
        private decimal _hourlyRate;
        private decimal _hoursPerWeek;

        //Properties

            //Properties don't have to be a direct relationship to a single variable.
            //Here I am using 2 variables to get the value for a single property.
        public decimal WeeklySalary
        {
            get
            {
                return this._hourlyRate * this._hoursPerWeek;
            }
        }

        //Methods

        public override string ToString()
        {
            //Use the weekly salary property declared above to make u p this ToString.
            //This way it will return the same string as Salary Employee even though
            //this employee is hourly.
            return base.ToString() + " " + this.WeeklySalary;
        }

        //Implement the abstract method declared in Employee.
        public override decimal GetYearlySalary()
        {
            return this.WeeklySalary * 52;
        }

        //Override the virtual method declared in the Employee class. I did not need
        //to override it. I could have used the parent class versions, but I decided to.
        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this.WeeklySalary;
        }

        //Constructors

            //Take in all five parameters that make up a hourly employee. Send the first
            //three parameters to the base constructor since it knows how to do the assignments
            //for me. Thin I just have to do the 2 remaining variables.
        public HourlyEmployee(string firstName, string lastName, DateTime startDate, decimal hourlyRate, decimal hoursPerWeek) :base(firstName, lastName, startDate)
        {
            this._hourlyRate = hourlyRate;
            this._hoursPerWeek = hoursPerWeek;
        }

    }
}
