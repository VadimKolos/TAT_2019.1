using System;

namespace taskDEV3
{
    /// <summary>
    /// This class shows information about employee by criterion.
    /// </summary>
    public class DisplayerScreen
    {
        public void ShowFirstCriterion(int[] employeeArray)
        {
            Console.WriteLine("Count of juniors: " + employeeArray[0]);
            Console.WriteLine("Count of middles: " + employeeArray[1]);
            Console.WriteLine("Count of seniors: " + employeeArray[2]);
            Console.WriteLine("Count of leads: " + employeeArray[3]);
            Console.WriteLine("Maximum productivity: " + employeeArray[4]);
        }

        public void ShowSecondCriterion(int[] employeeArray)
        {
            Console.WriteLine("Count of juniors: " + employeeArray[0]);
            Console.WriteLine("Count of middles: " + employeeArray[1]);
            Console.WriteLine("Count of seniors: " + employeeArray[2]);
            Console.WriteLine("Count of leads: " + employeeArray[3]);
            Console.WriteLine("Minimum total salary: " + employeeArray[4]);
        }

        public void ShowThirdCriterion(int[] employeeArray)
        {
            Console.WriteLine("Count of middles: " + employeeArray[0]);
            Console.WriteLine("Count of seniors: " + employeeArray[1]);
            Console.WriteLine("Count of leads: " + employeeArray[2]);
            Console.WriteLine("Minimum count of high qualified employees: " + employeeArray[3]);
        }
    }
}

