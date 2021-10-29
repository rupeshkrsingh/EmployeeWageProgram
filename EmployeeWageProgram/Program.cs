using System;

namespace EmployeeWageProgram
{
   public class Program
    {
        public static void Main(string[] args)
        {
            //constant 
            int isFullTime = 2;
            int isPartTime = 1;
            int empRatePerHour = 20;

            //variable
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck==isPartTime)
            {
                empHrs = 4;
            }
            else if (empCheck == isFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Emp Wage:" + empWage);
        }
    }
}
