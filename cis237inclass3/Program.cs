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
            Console.WriteLine(sEmployee.NameAndSalary());
        }
    }
}
