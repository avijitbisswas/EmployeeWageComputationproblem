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
            const int EMP_PRESENT = 0, EMP_ABSENT = 1, PAY_PER_HOUR = 20, FULL_WORK_HOUR = 8;
            Console.WriteLine("Employement Wage Computation Program");
            Console.ReadLine();
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == EMP_PRESENT) 
            {
                Console.WriteLine("Employee is present");
                Console.WriteLine("Daily Wage of the employee is " +PAY_PER_HOUR*FULL_WORK_HOUR);
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Employee is absent");
                Console.ReadLine();
            }

        
           





        }

    }
}
