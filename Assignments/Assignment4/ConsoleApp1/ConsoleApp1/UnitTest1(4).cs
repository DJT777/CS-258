using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // CalculateHourly Test Methods
        [TestMethod]
        public void TestBrown150Hourly()
        {
            // arrange
            Employee emp = new Employee("Malachi", "Brown", Employee.HOURLY, 150);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(6000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(600, emp.SocialSecurityTax);
            Assert.AreEqual(600, emp.WageTax);
            Assert.AreEqual(1210, emp.TotalTaxes);
            Assert.AreEqual(4790, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestBrown100Hourly()
        {
            // arrange
            Employee emp = new Employee("malachi", "Brown", Employee.HOURLY, 100);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(4000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(400, emp.SocialSecurityTax);
            Assert.AreEqual(400, emp.WageTax);
            Assert.AreEqual(810, emp.TotalTaxes);
            Assert.AreEqual(3190, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestBrown75Hourly()
        {
            // arrange
            Employee emp = new Employee("Malachi", "Brown", Employee.HOURLY, 75);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(3000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(300, emp.SocialSecurityTax);
            Assert.AreEqual(60, emp.WageTax);   // .02 tax rate
            Assert.AreEqual(370, emp.TotalTaxes);
            Assert.AreEqual(2630, emp.TakeHomePay);
        }

        [TestMethod]
        public void TestBrown50Hourly()
        {
            // arrange
            Employee emp = new Employee("Malachi", "Brown", Employee.HOURLY, 50);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(2000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(200, emp.SocialSecurityTax);   //.10 rate
            Assert.AreEqual(40, emp.WageTax);   // .02 tax rate
            Assert.AreEqual(250, emp.TotalTaxes);
            Assert.AreEqual(1750, emp.TakeHomePay);
        }

        [TestMethod]
        public void TestBrown25Hourly()
        {
            // arrange
            Employee emp = new Employee("Malachi", "Brown", Employee.HOURLY, 25);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(1000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(100, emp.SocialSecurityTax);   //.10 rate
            Assert.AreEqual(50, emp.WageTax);   // .05 tax rate
            Assert.AreEqual(160, emp.TotalTaxes);
            Assert.AreEqual(840, emp.TakeHomePay);
        }

        [TestMethod]
        public void TestSmith150Hourly()
        {
            // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.HOURLY, 150);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(6000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(600, emp.SocialSecurityTax);   //.10 rate
            Assert.AreEqual(600, emp.WageTax);   // .10 tax rate
            Assert.AreEqual(1210, emp.TotalTaxes);
            Assert.AreEqual(4790, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestSmith100Hourly()
        {  // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.HOURLY, 100);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(4000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(400, emp.SocialSecurityTax);   //.10 rate
            Assert.AreEqual(400, emp.WageTax);   // .10 tax rate
            Assert.AreEqual(810, emp.TotalTaxes);
            Assert.AreEqual(3190, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestSmith75Hourly()
        {
            // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.HOURLY, 75);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(3000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(300, emp.SocialSecurityTax);   //.10 rate
            Assert.AreEqual(240, emp.WageTax);   // .08 tax rate
            Assert.AreEqual(550, emp.TotalTaxes);
            Assert.AreEqual(2450, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestSmith50Hourly()
        {
            // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.HOURLY, 50);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(2000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(200, emp.SocialSecurityTax);   //.10 rate
            Assert.AreEqual(160, emp.WageTax);   // .08 tax rate
            Assert.AreEqual(370, emp.TotalTaxes);
            Assert.AreEqual(1630, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestSmith25Hourly()
        {
            // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.HOURLY, 25);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(1000, emp.GrossPay);
            Assert.AreEqual(Employee.HOURLY, emp.Type);
            Assert.AreEqual(10, emp.PlanetaryTax);
            Assert.AreEqual(100, emp.SocialSecurityTax);   //.10 rate
            Assert.AreEqual(50, emp.WageTax);   // .05 tax rate
            Assert.AreEqual(160, emp.TotalTaxes);
            Assert.AreEqual(840, emp.TakeHomePay);
        }

        // CalculateSalary Test Methods
        [TestMethod]
        public void TestBrown4000Salary()
        {
            // arrange
            Employee emp = new Employee("Malachi", "Brown", Employee.SALARY, 4000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(4000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(1, emp.PlanetaryTax);  // .25 * salary/1000
            Assert.AreEqual(400, emp.SocialSecurityTax);  
            Assert.AreEqual(0, emp.WageTax);   // 0
            Assert.AreEqual(401, emp.TotalTaxes);
            Assert.AreEqual(3599, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestBrown5000Salary()
        {
            // arrange
            Employee emp = new Employee("Malachi", "Brown", Employee.SALARY, 5000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(5000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(1.25, emp.PlanetaryTax);  // .00025
            Assert.AreEqual(500, emp.SocialSecurityTax);
            Assert.AreEqual(0, emp.WageTax);   // 0
            Assert.AreEqual(501.25, emp.TotalTaxes);
            Assert.AreEqual(4498.75, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestBrown6000Salary()
        {
            // arrange
            Employee emp = new Employee("Malachi", "Brown", Employee.SALARY, 6000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(6000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(1.5, emp.PlanetaryTax);  // .00025
            Assert.AreEqual(600, emp.SocialSecurityTax);
            Assert.AreEqual(0, emp.WageTax);   // 0
            Assert.AreEqual(601.5, emp.TotalTaxes);
            Assert.AreEqual(5398.5, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestBrown10000Salary()
        {
            // arrange
            Employee emp = new Employee("Malachi", "Brown", Employee.SALARY, 10000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(10000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(2.5, emp.PlanetaryTax);  // .00025
            Assert.AreEqual(1000, emp.SocialSecurityTax);
            Assert.AreEqual(0, emp.WageTax);   // 0
            Assert.AreEqual(1002.5, emp.TotalTaxes);
            Assert.AreEqual(8997.5, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestBrown11000Salary()
        {
            // arrange
            Employee emp = new Employee("Malachi", "Brown", Employee.SALARY, 11000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(11000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(2.75, emp.PlanetaryTax);  // .00025
            Assert.AreEqual(1100, emp.SocialSecurityTax);
            Assert.AreEqual(0, emp.WageTax);   // 0
            Assert.AreEqual(1102.75, emp.TotalTaxes);
            Assert.AreEqual(9897.25, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestSmith4000Salary()
        {
            // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.SALARY, 4000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(4000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(1, emp.PlanetaryTax);  // .00025
            Assert.AreEqual(400, emp.SocialSecurityTax);
            Assert.AreEqual(600, emp.WageTax);   // .15
            Assert.AreEqual(1001, emp.TotalTaxes);
            Assert.AreEqual(2999, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestSmith5000Salary()
        {
            // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.SALARY, 5000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(5000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(1.25, emp.PlanetaryTax);  // .00025
            Assert.AreEqual(500, emp.SocialSecurityTax);
            Assert.AreEqual(900, emp.WageTax);   // .18
            Assert.AreEqual(1401.25, emp.TotalTaxes);
            Assert.AreEqual(3598.75, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestSmith6000Salary()
        {
            // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.SALARY, 6000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(6000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(1.5, emp.PlanetaryTax);  // .00025
            Assert.AreEqual(600, emp.SocialSecurityTax);
            Assert.AreEqual(1080, emp.WageTax);   // .18
            Assert.AreEqual(1681.5, emp.TotalTaxes);
            Assert.AreEqual(4318.5, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestSmith10000Salary()
        {
            // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.SALARY, 10000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(10000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(2.5, emp.PlanetaryTax);  // .00025
            Assert.AreEqual(1000, emp.SocialSecurityTax);
            Assert.AreEqual(2200, emp.WageTax);   // .22
            Assert.AreEqual(3202.5, emp.TotalTaxes);
            Assert.AreEqual(6797.5, emp.TakeHomePay);
        }
        [TestMethod]
        public void TestSmith11000Salary()
        {
            // arrange
            Employee emp = new Employee("Bert", "Smith", Employee.SALARY, 11000);

            // act
            emp.CalculateTakeHome();

            // assert
            Assert.AreEqual(11000, emp.GrossPay);
            Assert.AreEqual(Employee.SALARY, emp.Type);
            Assert.AreEqual(2.75, emp.PlanetaryTax);  // .00025
            Assert.AreEqual(1100, emp.SocialSecurityTax);
            Assert.AreEqual(2420, emp.WageTax);   // .22
            Assert.AreEqual(3522.75, emp.TotalTaxes);
            Assert.AreEqual(7477.25, emp.TakeHomePay);
        }
        /*
        // CalculateTakeHome Test Methods - Only test that it takes the correct path to Hourly or Salary
        // not that it calculates it correctly since those are handled with the Hourly and Salary tests above
        // for CalculateHourly and CalculateSalary
        [TestMethod]
        public void TestHourly()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TestSalary()
        {
            Assert.Inconclusive();
        }

        // Test GetTaxes() - test that if the GetPlanetaryTax and GetSocialSecurityTax and GetWageTax return the right
        // thing that it returns the right thing
        [TestMethod]
        public void TestGetTaxes()
        {
            Assert.Inconclusive();
        }


        // Test GetPlanetaryTax - Test that it returns the right thing for hourly or salary
        [TestMethod]
        public void TestGetPlanetaryTaxHourly()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TestGetPlanetaryTaxSalary()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        // Test GetSocialSecurityTax
        public void TestGetSocialSecurityTax()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        // Test GetWageTax
        public void TestGetWageTaxGrossPay0()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TestGetWageTaxGrossPay22()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TestGetWageTaxGrossPay18()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TestGetWageTaxGrossPay15()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TestGetWageTaxGrossPay2()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TestGetWageTaxGrossPay8()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TestGetWageTaxGrossPay5()
        {
            Assert.Inconclusive();
        }
        */
    }

}
