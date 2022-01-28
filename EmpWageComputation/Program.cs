using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class Program
    {
        const int EMP_PRESENT = 0, EMP_ABSENT = 1, PAY_PER_HOUR = 20, FULL_WORK_HOUR = 8, PART_TIME_WORK = 4;
        
        public static void Main()
        {
            int workhour = 100;
            Console.WriteLine("Employement Wage Computation Program");
            Console.ReadLine();
            Random random = new Random();
            int empcheck = random.Next(0,3);
            switch (empcheck)
            {
                case 1:
                    empcheck = FULL_WORK_HOUR;
                    Console.WriteLine("Employee is Present");
                    Console.WriteLine("Monthly Wage of the employee(full-time) is " + PAY_PER_HOUR * FULL_WORK_HOUR * 20);
                    Console.ReadLine();
                    
                    break;

                case 2:
                    empcheck = PART_TIME_WORK;
                    Console.WriteLine("Employee is present but Half Day");
                    Console.WriteLine("Work Our is less than 100hors");
                        Console.ReadLine();
                    break;
                default: Console.WriteLine("Employee is Absent."); 
                    Console.ReadLine() ;
                    empcheck = 0;
                    break;
            }
            
            workfilter workfilter = new workfilter();
            workfilter.HoursFilter();
            Console.ReadLine();







        }

        








        

    }
}
