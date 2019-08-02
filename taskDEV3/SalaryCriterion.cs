using System;

namespace taskDEV3
{
    /// <summary>
    /// This class create a team be the second criterion. 
    /// </summary>
    public class SalaryCriterion
    {
        Junior constantJuniorParams;
        Middle constantMiddleParams;
        Senior constantSeniorParams;
        Lead constantLeadParams;

        public SalaryCriterion()
        {
            constantJuniorParams = new Junior();
            constantMiddleParams = new Middle();
            constantSeniorParams = new Senior();
            constantLeadParams = new Lead();
        }

        /// <summary>
        /// This method create a team by the second criterion.
        /// </summary>        
        /// <param name="inputProductivity">value of productivity which user was inputed</param>
        /// <param name="employeesArray">array of values about created team and total Salary</param>
        public int[] MinSalaryCalculate(int inputProductivity)
        {
            /// <summary>
            /// Take salary of each employee.
            /// </summary>
            int junSalary = constantJuniorParams.Salary;
            int middleSalary = constantMiddleParams.Salary;
            int seniorSalary = constantSeniorParams.Salary;
            int leadSalary = constantLeadParams.Salary;

            /// <summary>
            /// Take productivity of each employee.
            /// </summary>
            int junProductivity = constantJuniorParams.Productivity;
            int middleProductivity = constantMiddleParams.Productivity;
            int seniorProductivity = constantSeniorParams.Productivity;
            int leadProductivity = constantLeadParams.Productivity;

            /// <summary>
            /// Start values of count of employee.
            /// </summary>
            int needCountOfJuns = 0;
            int needCountOfMiddles = 0;
            int needCountOfSeniors = 0;
            int needCountOfLeads = 0;


            int totalSalary = 0;

            for (int i = 0; inputProductivity >= junProductivity; i++)
            {
                if (inputProductivity >= leadProductivity)
                {
                    totalSalary = totalSalary + leadSalary;
                    inputProductivity = inputProductivity - leadProductivity;
                    needCountOfLeads++;
                }
                else if (inputProductivity >= seniorProductivity && inputProductivity < leadProductivity)
                {
                    totalSalary = totalSalary + seniorSalary;
                    inputProductivity = inputProductivity - seniorProductivity;
                    needCountOfSeniors++;
                }
                else if (inputProductivity >= middleProductivity && inputProductivity < seniorProductivity)
                {
                    totalSalary = totalSalary + middleSalary;
                    inputProductivity = inputProductivity - middleProductivity;
                    needCountOfMiddles++;
                }
                else if (inputProductivity >= junProductivity && inputProductivity < middleProductivity)
                {
                    totalSalary = totalSalary + junSalary;
                    inputProductivity = inputProductivity - junProductivity;
                    needCountOfJuns++;
                }
                else
                {
                    Console.WriteLine("Not enogh employees");
                    break;
                }
            }
            int[] employeesArray = { needCountOfJuns, needCountOfMiddles, needCountOfSeniors, needCountOfLeads, totalSalary };
            return employeesArray;
        }
    }
}