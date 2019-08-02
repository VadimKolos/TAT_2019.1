using System;

namespace task_DEV3
{
    /// <summary>
    /// This class create a team be the first criterion. 
    /// </summary>
    public class FirstCriterion
    {
        Junior constantJuniorParams;
        Middle constantMiddleParams;
        Senior constantSeniorParams;
        Lead constantLeadParams;

        public FirstCriterion()
        {
            constantJuniorParams = new Junior();
            constantMiddleParams = new Middle();
            constantSeniorParams = new Senior();
            constantLeadParams = new Lead();
        }

        /// <summary>
        /// This method create a team by the first criterion.
        /// </summary>
        /// <param name="inputMoney">count of money which user was inputed</param>                
        public int[] MaxProductivityCalculate(int inputMoney)
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

            int totalProductivity = 0;

            for (int i = 0; inputMoney >= junSalary; i++)
            {
                if (inputMoney >= leadSalary)
                {
                    totalProductivity = totalProductivity + leadProductivity;
                    inputMoney = inputMoney - leadSalary;
                    needCountOfLeads++;
                }
                else if (inputMoney >= seniorSalary && inputMoney < leadSalary)
                {
                    totalProductivity = totalProductivity + seniorProductivity;
                    inputMoney = inputMoney - seniorSalary;
                    needCountOfSeniors++;
                }
                else if (inputMoney >= middleSalary && inputMoney < seniorSalary)
                {
                    totalProductivity = totalProductivity + middleProductivity;
                    inputMoney = inputMoney - middleSalary;
                    needCountOfMiddles++;
                }
                else if (inputMoney >= junSalary && inputMoney < middleSalary)
                {
                    totalProductivity = totalProductivity + junProductivity;
                    inputMoney = inputMoney - junSalary;
                    needCountOfJuns++;
                }
                else
                {
                    Console.WriteLine("Not enogh employees");
                    break;
                }
            }
            int[] employeesArray = { needCountOfJuns, needCountOfMiddles, needCountOfSeniors, needCountOfLeads, totalProductivity };
            return employeesArray;
        }
    }
}
