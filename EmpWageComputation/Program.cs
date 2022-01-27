using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class Program
    {
        public static void Main()
        {
            const int EMP_PRESENT = 0, EMP_ABSENT = 1, PAY_PER_HOUR = 20, FULL_WORK_HOUR = 8 , PART_TIME_WORK=4;
            Console.WriteLine("Employement Wage Computation Program");
            Console.ReadLine();
            Random random = new Random();
            int empcheck = random.Next(0,2);
            if (empcheck == 0) 
            {
                Random random2 = new Random();
                int work = random2.Next(0, 2);
                if (work==0) //full day work taking random as 0
                {

                    Console.WriteLine("Employee is present");
                    Console.WriteLine("Daily Wage of the employee is " + PAY_PER_HOUR * FULL_WORK_HOUR);
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("Employee is present half day");
                    Console.WriteLine("Part Time Wage of Employee is" +PAY_PER_HOUR*PART_TIME_WORK);
                }
            }
            else 
            {
                Console.WriteLine("Employee is absent");
                Console.ReadLine();
            }

        
           





        }

    }
}
