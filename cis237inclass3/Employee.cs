using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Employee
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
        
        public DayOfWeek GetStartDay()
        {
            return _startDate.DayOfWeek;
        }

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
