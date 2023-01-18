using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Impl.EmpWageComputaionProb
{
    public class CompanyWage
    {
        public const int Emp_FullTime = 1;
        public const int Emp_PartTime = 2;
        public const int Present = 1;

        private string CompanyName;
        private int WagePerHr;
        private int MonthlyWorkingDays;
        private int MaxHoursPerMonth;

        private int EmpWage;

        public CompanyWage()
        {
            Console.WriteLine("Welcome to Employee wage computation program");

            Console.WriteLine("1 for ateendence");
            Console.WriteLine("2 for calculating daily wage");
            Console.WriteLine("3 for calculating monthly wage");
            Console.WriteLine("4 for calculating wage on constraint");

        }
        public CompanyWage(string companyName, int wageRatePerHr, int monthlyWorkingdays, int maxHoursPerMonth)
        {
            CompanyName = companyName;
            WagePerHr = wageRatePerHr;
            MonthlyWorkingDays = monthlyWorkingdays;
            MaxHoursPerMonth = maxHoursPerMonth;

        }

        
        

        public void SetEmpWage(int wage)
        {
            EmpWage=wage;
            return;
        }

        public int GetEmpWage()
        {
            return EmpWage;
        }

        public string GetCompanyName()
        {
            return CompanyName;
        }

        public int GetWagePerHr()
        {
            return WagePerHr;
        }

        public int GetMonthlyWorkingDays()
        {
            return MonthlyWorkingDays;
        }

        public int GetMaxHoursPerMonth()
        {
            return MaxHoursPerMonth;
        }


        public bool IsPresent()
        {

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Present) return true;
            return false;
        }

        public int DailyEmpWage()
        {
            int EmpHours = 0;

            if (IsPresent())
            {
                Random random = new Random();
                int EmpType = random.Next(0, 3);

                //using switch statement
                switch (EmpType)
                {
                    case Emp_FullTime:
                        EmpHours = 8;
                        break;
                    case Emp_PartTime:
                        EmpHours = 4; break;
                    default: EmpHours = 0; break;
                }

            }
            else EmpHours = 0;
            int wage = EmpHours * WagePerHr;
            return wage;
        }

        public int MonthlyEmpWage()
        {
            //variables
            int MonthlyWage = 0;
            for (int i = 0; i < MonthlyWorkingDays; i++)
            {
                MonthlyWage += DailyEmpWage();
            }
            return MonthlyWage;
        }

        public void WagesTill100()
        {
            //variables
            int wage = 0;
            int workhrs = 0;

            for (int i = 0; i < MonthlyWorkingDays; i++)
            {
                int DailyWage = DailyEmpWage();
                if (DailyWage == 160) workhrs += 8;
                else if (DailyWage > 0) workhrs += 4;
                wage += DailyWage;
                if (workhrs == 100)
                {
                    Console.WriteLine("Monthly Hrs limit exceed. Total wage is " + wage);
                    return;
                }
            }
            Console.WriteLine("Monthly Days are over. Total wage is " + wage);
            return;
        }


        


    }
}
