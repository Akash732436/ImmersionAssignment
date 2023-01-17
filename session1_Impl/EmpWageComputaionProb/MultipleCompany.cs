using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Impl.EmpWageComputaionProb
{
    public class MultipleCompany
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
            company.SetEmpWage();
            Companies.Add(company);
            Console.WriteLine("Company has been added.");

        }

        public void DeleteCompany(string CompanyName)
        {
            foreach (var company in Companies)
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
                }
            }
        }

    }
}
