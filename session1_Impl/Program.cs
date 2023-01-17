﻿using session1_Impl.EmpWageComputaionProb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Impl
{


    class Program
    {

        public static void EmpWage()
        {
            EmpWageProblem empWage = new EmpWageProblem();

            //Choice of user
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    bool EmpAttend = empWage.IsPresent();
                    if (EmpAttend)
                    {
                        Console.WriteLine("Employe is present");
                    }
                    else
                        Console.WriteLine("Employee is absent");
                    break;
                case '2':
                    int dailyWage = empWage.DailyEmpWage();
                    Console.WriteLine("Daily wage of employee is " + dailyWage);
                    break;
                case '3':
                    int monthlyWage = empWage.MonthlyEmpWage();
                    Console.WriteLine("Monthly wage of employee is " + monthlyWage);
                    break;
                case '4':
                    empWage.WagesTill100();
                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;
            }
        }

        public static void LineCompare()
        {
            LineComparison lineComparison = new LineComparison();

            //Choice of user
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    double lineLength = lineComparison.LengthOfLine();
                    Console.WriteLine("Length of the line is "+lineLength);
                    break;
                case '2':
                    bool lineEqaul = lineComparison.CheckIfEqual();
                    if (lineEqaul)
                    {
                        Console.WriteLine("Lines are equal");
                    }
                    else
                    {
                        Console.WriteLine("Lines are not equal");
                    }
                    break;
                case '3':
                    int lineCmp = lineComparison.CompareLines();
                    if(lineCmp> 0)
                    {
                        Console.WriteLine("Line1 is greater than line2");
                    }else if (lineCmp < 0)
                    {
                        Console.WriteLine("Line1 is smaller than line2");
                    }
                    else
                    {
                        Console.WriteLine("Both lines re equal");
                    }
                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;
            }
        }

        static void Main(string[] args)
        {
            //Uncomment the next line for employee wage problem.
            //EmpWage();


            //Uncomment the next line for line comprison problem
            //LineCompare();


            string companyName = "abc";
            int wagePerhr = 20;
            int workdays = 20;
            int maxHrspermonth = 200;
            MultipleCompany multiple=new MultipleCompany();
            multiple.AddCompany(companyName, wagePerhr, workdays, maxHrspermonth);

            companyName = "other company";
            wagePerhr = 10;
            workdays = 25;
            wagePerhr = 20;
            maxHrspermonth = 200;
            multiple.AddCompany(companyName, wagePerhr, workdays, maxHrspermonth);

            multiple.GetCompany("abc");

            Console.ReadLine();
        }
    }
}
