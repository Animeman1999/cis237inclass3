using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    //Make this class abstract.  This way it can not be instaciated on it's own, but will
    //provice a good base for the other tow types of employees.
    public abstract class Employee : IEmployee 
    {
        //Variables
        protected string _firstname;
        protected string _lastname;
        protected DateTime _startDate;

        //Properties
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        //Methods
        public override string ToString()
        {
            return _firstname + " " + _lastname;
        }
        

        public int GetEmploymentDurationInYear()
        {
            //Subtract the ticks of the start date from, and then get the days and divid it by 365
            return new TimeSpan(DateTime.Now.Ticks - this._startDate.Ticks).Days / 365;
        }

        public virtual string GetAllEmployeeInformation()//NOTE made virtual so it can be overidden.
        {
            //Take all of the properties for the employee and concat them together.
            return this._firstname + " " + this._lastname + " " + this.GetEmploymentDurationInYear();
        }

        //Get the Yearly Salary of the employee
        //Make the method abstract because we want the sub classes to implement it, but
        //at this level we don't know how to implement it.
        public abstract decimal GetYearlySalary();

        //Constructors

        public Employee(string FirstName, string LastName, DateTime StartDate)
        {
            this._firstname = FirstName;
            this._lastname = LastName;
            this._startDate = StartDate;
        }

        public Employee() { }

    }
}
