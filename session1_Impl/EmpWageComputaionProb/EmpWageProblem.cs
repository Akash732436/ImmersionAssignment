using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace session1_Impl
{
    public class EmpWageProblem
    {
        public EmpWageProblem()
        {
            Console.WriteLine("Welcome to Employee wage computation program");

            Console.WriteLine("1 for ateendence");
            Console.WriteLine("2 for calculating daily wage");
            Console.WriteLine("3 for calculating monthly wage");
            Console.WriteLine("4 for calculating wage on constraint");
            Console.WriteLine("5 for part time employee");

        }
        public bool IsPresent()
        {
            int Present = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck==Present) return true;
            return false;
        }

        public int DailyEmpWage()
        {
            int EmpRatePerHour = 20;
            int EmpHours = 0;
            if (IsPresent()) EmpHours = 8;
            else EmpHours = 0;
            int wage = EmpHours * EmpRatePerHour;
            return wage;
        }

        public int MonthlyEmpWage()
        {
            int MonthlyWage = 0;
            for(int i = 0; i < 10; i++)
            {
                MonthlyWage += DailyEmpWage();
            }
            return MonthlyWage;
        }

        public void WagesTill100()
        {
            int wage = 0;
            int workhrs = 0;
            for(int i = 0; i < 20; i++)
            {
                int DailyWage = DailyEmpWage();
                if (DailyWage > 0) workhrs += 1;
                wage += DailyWage;
                if(workhrs==100)
                {
                    Console.WriteLine("Monthly Hrs limit exceed. Total wage is "+wage);
                    return;
                }
            }
            Console.WriteLine("Monthly Days are over. Total wage is "+ wage);
            return;
        }

        /*
        public void CheckPresentAbsent()
        {
            Console.WriteLine("Welcome to emloyee wage");
            //constant
            int present = 1;
            int EmpRatePerHour = 20;

            //local
            int EmpHours = 0;
            int EmpWage = 0;

            Random random = new Random();
            int EmpCheck = random.Next(0,2);
            Console.WriteLine("random value is "+EmpCheck);

            if (EmpCheck == present)
            {
                EmpHours = 8;
                Console.WriteLine("Employee is present");
            }
            else
            {
                EmpHours = 0;
                Console.WriteLine("Employee is absent");
            }
            EmpWage = EmpHours * EmpRatePerHour;
            Console.WriteLine("Employe wage of a day is "+EmpWage);

        }
        */
    }
}
