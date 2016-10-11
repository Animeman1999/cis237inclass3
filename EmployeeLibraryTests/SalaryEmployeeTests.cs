using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary.Tests
{
    [TestClass()]
    public class SalaryEmployeeTests
    {
        [TestMethod()]
        public void NameAndSalaryTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 250m);
            string expected = "David Barnes $250.00";

            //Act
            string actual = salaryEmployee.NameAndSalary();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 250m);
            string expected = "David Barnes 250";

            //Act
            string actual = salaryEmployee.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAllEmployeeInformationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetYearlySalaryTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 250m);
            decimal expected = 13000m;

            //Act
            decimal actual = salaryEmployee.GetYearlySalary();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SalaryEmployeeTest()
        {
            //Arrange
            string expectedFirstName = "David";
            string expctedLastName = "Barnes";
            DateTime expectedDateTime = new DateTime(2016, 10, 10);
            decimal expectedWeeklySalary = 250m;


            //Act

            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 250m);


                      
            //Assert
            Assert.AreEqual(expectedFirstName, salaryEmployee.FirstName);
            Assert.AreEqual(expctedLastName, salaryEmployee.LastName);
            Assert.AreEqual(expectedDateTime, salaryEmployee.StartDate);
            Assert.AreEqual(expectedWeeklySalary, salaryEmployee.WeeklySalary);
        }

        [TestMethod()]
        public void SalaryEmployeeTest1()
        {
            Assert.Fail();
        }
    }
}