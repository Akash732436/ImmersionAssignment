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
        private const int EmpFullTime = 1;
        private const int EmpPartTime = 2;
        private const int Present = 1;
        private const int WagePerHour= 20;
        private const int FullDayHour = 8;
        private const int PartTimeHour = 4;

        public EmpWageProblem()
        {
            Console.WriteLine("Welcome to Employee wage computation program");

            Console.WriteLine("1 for ateendence");
            Console.WriteLine("2 for calculating daily wage");
            Console.WriteLine("3 for calculating monthly wage");
            Console.WriteLine("4 for calculating wage on constraint");
            Console.WriteLine("5 for wage of part time employee");

        }
        public bool IsPresent()
        {

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck==Present) return true;
            return false;
        }

        public int DailyEmpWage()
        {
            int EmpHours = 0;

            if (IsPresent()) { 
                Random random= new Random();
                int EmpType=random.Next(0, 3);
                int EmpHrs = 0;
                switch (EmpType)
                {
                    case EmpFullTime:
                        EmpHrs = 8;
                        break;
                    case EmpPartTime:
                        EmpHrs = 4; break;
                    default: EmpHrs = 0; break;
                }
             
            }
            else EmpHours = 0;
            int wage = EmpHours * WagePerHour;
            return wage;
        }

        public int MonthlyEmpWage()
        {
            //variables
            int MonthlyWage = 0;
            for(int i = 0; i < 19; i++)
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

        //public int PartTimeWage()
        //{

        //    //int WagePerHour = 10;
        //    //int WorkingHours = 8;

        //    //bool Present = IsPresent();

        //    //switch (Present)
        //    //{
        //    //    case true:
        //    //        int total = WagePerHour * WorkingHours;
        //    //        return total;
        //    //    default:
        //    //        return 0;

        //    //}


        //    int EmpHrs = 0;
        //    Random random=new Random();
        //    int EmpType=random.Next(0,3);
        //    switch(EmpType)
        //    {
        //        case EmpFullTime:
        //            EmpHrs = 8;
        //            break;
        //        case EmpPartTime:
        //            EmpHrs = 4; break;
        //        default: EmpHrs = 0; break;
        //    }
        //    int dailyWage = EmpHrs * 20;
        //    return dailyWage;

        //}

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
