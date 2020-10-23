using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        const double HOURLY_TAX_RATE_TEN = .1;
        const double HOURLY_TAX_RATE_TWO = .02;
        const double HOURLY_TAX_RATE_EIGHT = .08;
        const double HOURLY_TAX_RATE_FIVE = .05;
        const double SALARY_TAX_RATE_TWENTY_TWO = .22;
        const double SALARY_TAX_RATE_EIGHTEEN = .18;
        const double SALARY_TAX_RATE_FIFTEEN = .15;
        const double SOCIAL_SECURITY_RATE = .1;
        const double PLANETARY_TAX_RATE = .25;
        
        private string firstName;
        private string lastName;
        private string payType;
        private double payRate;
        private double takeHomePay;      
        

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string PayType
        {
            get
            {
                return payType;
            }
            set
            {
                payType = value;
            }
        }

        public double PayRate
        {
            get
            {
                return payRate;
            }
            set
            {
                payRate = value;
            }
        }

        public double TakeHomePay
        {
            get
            {
                return takeHomePay;
            }
            set
            {
                takeHomePay = value;
            }
        }


       public Employee(string employeeFirstName, string employeeLastName, string employeePayType, double employeePayRate)
        {
            FirstName = employeeFirstName;
            LastName = employeeLastName;
            PayType = employeePayType;
            PayRate = employeePayRate;
            takeHomePay = CalculateTakeHomePay(lastName, payType, payRate);

            
        }

        private double CalculateTakeHomePay(string employeeLastName, string employeePayType, double employeePayRate)
        {
            double calculatedPay = 0;

            if (employeePayType == "Salary")
            {
                double SALARY_PLANETARY_TAX_DEDUCTION = Math.Floor((PayRate / 1000)) * PLANETARY_TAX_RATE;

                if (employeeLastName == "Brown")
                {
                    calculatedPay = employeePayRate - (SALARY_PLANETARY_TAX_DEDUCTION) - (employeePayRate * SOCIAL_SECURITY_RATE);
                   
                }
                else if (payRate >= 10000.00){
                    calculatedPay = employeePayRate - (employeePayRate * SALARY_TAX_RATE_TWENTY_TWO) - SALARY_PLANETARY_TAX_DEDUCTION - (employeePayRate * SOCIAL_SECURITY_RATE);
                    
                }
                else if (payRate >= 5000.00 && payRate < 10000.00){
                    calculatedPay = employeePayRate - (employeePayRate * SALARY_TAX_RATE_EIGHTEEN) - SALARY_PLANETARY_TAX_DEDUCTION - (employeePayRate * SOCIAL_SECURITY_RATE);
                }
                else if (payRate < 5000.00){
                    calculatedPay = employeePayRate - (employeePayRate * SALARY_TAX_RATE_FIFTEEN) - SALARY_PLANETARY_TAX_DEDUCTION - (employeePayRate * SOCIAL_SECURITY_RATE);
                }
            
                
            }
            else if (employeePayType == "Hourly")
            {
                double hoursWorked = 40;
                double weeklyGross = hoursWorked * employeePayRate;
                double HOURLY_PLANETARY_TAX_DEDUCTION = 40 * PLANETARY_TAX_RATE;



                if (employeePayRate > 100.00)
                {
                    calculatedPay = weeklyGross - (HOURLY_TAX_RATE_TEN * weeklyGross) - HOURLY_PLANETARY_TAX_DEDUCTION - (weeklyGross * SOCIAL_SECURITY_RATE);
                }
                else if (employeePayRate < 100.00 & employeePayRate >= 50.00 & lastName == "Brown")
                {
                    calculatedPay = weeklyGross - (HOURLY_TAX_RATE_TWO * weeklyGross) - HOURLY_PLANETARY_TAX_DEDUCTION - (weeklyGross * SOCIAL_SECURITY_RATE);
                }
                else if (employeePayRate < 100.00 & employeePayRate >= 50.00 & lastName != "Brown")
                {
                    calculatedPay = weeklyGross - (HOURLY_TAX_RATE_EIGHT * weeklyGross) - HOURLY_PLANETARY_TAX_DEDUCTION - (weeklyGross * SOCIAL_SECURITY_RATE);
                }
                else if (employeePayRate < 50.00)
                {
                    calculatedPay = weeklyGross - (HOURLY_TAX_RATE_FIVE * weeklyGross) - HOURLY_PLANETARY_TAX_DEDUCTION - (weeklyGross * SOCIAL_SECURITY_RATE);
                }
            }
            else
            {
                calculatedPay = 9001;
            }

            return calculatedPay;
        }

        public override string ToString()
        {
            if (payType == "Hourly")
            {
                return "Employee " + firstName + " " + lastName + " is a " + payType + " earner that makes " + payRate + " per hour" + Environment.NewLine + "Monthly take home salary is " + takeHomePay.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")) + " after taxes.";

            }
            else if (payType == "Salary") {
                return "Employee " + firstName + " " + lastName + " is a " + payType + " earner that makes " + payRate.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")) + " per month." + Environment.NewLine + "Weekly take home salary is " + takeHomePay.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")) + " after taxes.";
            }
            else
            {
                return "oops";
            }
    }


    }

    
}
