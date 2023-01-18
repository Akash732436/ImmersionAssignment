using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Impl.EmpWageComputaionProb
{
    public interface IMultipleCompany
    {
        void GetCompany(string companyName);
        void AddCompany(string companyName, int wageRatePerHr, int monthlyWorkingdays, int maxHoursPerMonth);
        void DeleteCompany(string CompanyName);
        void SetEmpWage();
        void SetEmpWage(CompanyWage company);

    }
}
