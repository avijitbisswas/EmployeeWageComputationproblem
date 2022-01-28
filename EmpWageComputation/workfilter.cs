using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class workfilter
    {
        const int PRESENT = 1, ABSENT = 0, PART_TIME = 2, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, PART_TIME_HOUR = 4, WORKING_DAYS = 20;
        int days = WORKING_DAYS, workhrs, dailyWage = 0, totalWage = 0, i = 0, totalworkHours = 0;
        public void HoursFilter()
        {
            Random random = new Random();

            int dailyWage = 0, totalWage = 0, i = 0, totalworkHours = 0;

            while (days > 0 && totalworkHours <= 100)
            {
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case PRESENT:
                        dailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                        totalWage += dailyWage;
                        totalworkHours += FULL_DAY_HOUR;
                        workhrs = FULL_DAY_HOUR;
                        break;

                    case PART_TIME:
                        dailyWage = WAGE_PER_HOUR * PART_TIME_HOUR;
                        totalWage += dailyWage;
                        totalworkHours += PART_TIME_HOUR;
                        workhrs = PART_TIME_HOUR;
                        break;

                    case ABSENT:
                        dailyWage = 0;
                        totalWage += dailyWage;
                        break;
                }

                dailyWage = WAGE_PER_HOUR * workhrs;
                totalWage += dailyWage;
                totalworkHours += PART_TIME_HOUR;

                Console.WriteLine($"Everyday wage {i + 1} is: Rs " + dailyWage);
                i++;
                days--;
            }
            Console.WriteLine("Total Working Hours for 20days: " + totalworkHours);
            Console.WriteLine("The Monthly wage is: Rs " + totalWage);
            Console.WriteLine("Total Working Hours calculated: " + totalworkHours + "The total Monthly wage is: Rs " + totalWage);

        }
    }
}
