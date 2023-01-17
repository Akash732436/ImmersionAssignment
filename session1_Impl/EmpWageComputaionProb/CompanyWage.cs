﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Impl.EmpWageComputaionProb
{
    public class CompanyWage
    {
        private const int Emp_FullTime = 1;
        private const int Emp_PartTime = 2;
        private const int Present = 1;

        private string CompanyName;
        private int WagePerHr;
        private int MonthlyWorkingDays;
        private int MaxHoursPerMonth;

        private int EmpWage;

        public CompanyWage()
        {

        }
        public CompanyWage(string companyName, int wageRatePerHr, int monthlyWorkingdays, int maxHoursPerMonth)
        {
            CompanyName = companyName;
            WagePerHr = wageRatePerHr;
            MonthlyWorkingDays = monthlyWorkingdays;
            MaxHoursPerMonth = maxHoursPerMonth;
        }

        public void SetEmpWage()
        {
            int CurrEmpHrs = 0;
            int Workdays = 0;
            while (CurrEmpHrs < MaxHoursPerMonth && Workdays < MonthlyWorkingDays)
            {
                int TempEmpHrs = 0;
                Random random = new Random();
                int EmpType = random.Next(0, 3);
                switch (EmpType)
                {
                    case Emp_FullTime:
                        TempEmpHrs = 8;
                        break;
                    case Emp_PartTime:
                        TempEmpHrs = 4;
                        break;
                    default: break;
                }
                Workdays += 1;
                CurrEmpHrs += TempEmpHrs;

            }
            int MonthlyWage = CurrEmpHrs * WagePerHr;
            Console.WriteLine("No of days employee worked in " + CompanyName + ": " + Workdays);
            Console.WriteLine("No of hours employee worked in " + CompanyName + ": " + CurrEmpHrs);
            Console.WriteLine("Monthly wage of the employee is: " + MonthlyWage);
            EmpWage = MonthlyWage;
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
