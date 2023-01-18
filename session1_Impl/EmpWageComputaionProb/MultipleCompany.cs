using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Impl.EmpWageComputaionProb
{
    public class MultipleCompany : IMultipleCompany
    {
        private const int FullTime = 1;
        private const int PartTime = 2;

        private List<CompanyWage> Companies;

        public MultipleCompany()
        {
            this.Companies = new List<CompanyWage>();
        }

        public void AddCompany(string companyName, int wageRatePerHr, int monthlyWorkingdays, int maxHoursPerMonth)
        {
            CompanyWage company= new CompanyWage(companyName,wageRatePerHr,monthlyWorkingdays,maxHoursPerMonth);
            Companies.Add(company);
            Console.WriteLine("Company has been added.");
        }

        public void DeleteCompany(string CompanyName)
        {
            foreach (var company in Companies.ToList())
            {
                if (company.GetCompanyName() == CompanyName)
                {
                    Companies.Remove(company);
                }
            }
            Console.WriteLine("Company information has been deleted successfully");
        }

        public void GetCompany(string CompanyName)
        {
            foreach (var company in Companies)
            {
                if (company.GetCompanyName() == CompanyName)
                {
                    Console.WriteLine("Company name is: " + CompanyName);
                    Console.WriteLine("Monthly working days: "+ company.GetMonthlyWorkingDays());
                    Console.WriteLine("Max hours per month: "+company.GetMaxHoursPerMonth());
                    Console.WriteLine("Employee wage: "+company.GetEmpWage());
                    return;
                }
            }
            Console.WriteLine("No company found with that name");
        }



        public void SetEmpWage()
        {
            foreach(var company in Companies.ToList())
            {
                this.SetEmpWage(company);
                Console.WriteLine("Company name: "+company.GetCompanyName());
                Console.WriteLine("Employee wage: "+company.GetEmpWage());
                Console.WriteLine("\n\n");
            }
        }


        public void SetEmpWage(CompanyWage company)
        {
            int CurrEmpHrs = 0;
            int Workdays = 0;
            while (CurrEmpHrs < company.GetMaxHoursPerMonth() && Workdays < company.GetMaxHoursPerMonth())
            {
                int TempEmpHrs = 0;
                Random random = new Random();
                int EmpType = random.Next(0, 3);
                switch (EmpType)
                {
                    case CompanyWage.Emp_FullTime:
                        TempEmpHrs = 8;
                        break;
                    case CompanyWage.Emp_PartTime:
                        TempEmpHrs = 4;
                        break;
                    default: break;
                }
                Workdays += 1;
                CurrEmpHrs += TempEmpHrs;

            }
            int MonthlyWage = CurrEmpHrs * company.GetWagePerHr();
            Console.WriteLine("No of days employee worked in " + company.GetCompanyName() + ": " + Workdays);
            Console.WriteLine("No of hours employee worked in " + company.GetCompanyName() + ": " + CurrEmpHrs);
            Console.WriteLine("Monthly wage of the employee is: " + MonthlyWage);
            company.SetEmpWage(MonthlyWage);
            return;
        }


    }
}
