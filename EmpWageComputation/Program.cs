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
            const int EMP_PRESENT = 0, EMP_ABSENT = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == 0)
            {
                Console.WriteLine("Employee is Preent");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employe is absent");
                Console.ReadLine();
                
            }
            return;
           
        }
                
    }
}
