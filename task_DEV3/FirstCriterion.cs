using System;

namespace task_DEV3
{
    /// <summary>
    /// This class create a team be the first criterion. 
    /// </summary>
    class FirstCriterion
    {
        Junior constJuniorParams;
        Middle constMiddleParams;
        Senior constSeniorParams;
        Lead constLeadParams;

        public FirstCriterion()
        {
            constJuniorParams = new Junior();
            constMiddleParams = new Middle();
            constSeniorParams = new Senior();
            constLeadParams = new Lead();
        }

        /// <summary>
        /// This method create a team by the first criterion.
        /// </summary>
        /// <param name="_inputMoney">count of money which user was inputed</param>        
        /// <param name="employeesArray">array of values about created team and total productivity</param>
        public int[] MaxProductivityCalculate(int _inputMoney)
        {
            /// <summary>
            /// Take salary of each employee.
            /// </summary>
            int junSalary = constJuniorParams.Salary;
            int middleSalary = constMiddleParams.Salary;
            int seniorSalary = constSeniorParams.Salary;
            int leadSalary = constLeadParams.Salary;

            /// <summary>
            /// Take productivity of each employee.
            /// </summary>
            int junProductivity = constJuniorParams.Productivity;
            int middleProductivity = constMiddleParams.Productivity;
            int seniorProductivity = constSeniorParams.Productivity;
            int leadProductivity = constLeadParams.Productivity;

            /// <summary>
            /// Start values of count of employee.
            /// </summary>
            int needCountOfJuns = 0;
            int needCountOfMiddles = 0;
            int needCountOfSeniors = 0;
            int needCountOfLeads = 0;
            int totalProductivity = 0;
            for (int i = 0; _inputMoney >= junSalary; i++)
            {
                if (_inputMoney >= leadSalary)
                {
                    totalProductivity = totalProductivity + leadProductivity;
                    _inputMoney = _inputMoney - leadSalary;
                    needCountOfLeads++;
                }
                else if (_inputMoney >= seniorSalary && _inputMoney < leadSalary)
                {
                    totalProductivity = totalProductivity + seniorProductivity;
                    _inputMoney = _inputMoney - seniorSalary;
                    needCountOfSeniors++;
                }
                else if (_inputMoney >= middleSalary && _inputMoney < seniorSalary)
                {
                    totalProductivity = totalProductivity + middleProductivity;
                    _inputMoney = _inputMoney - middleSalary;
                    needCountOfMiddles++;
                }
                else if (_inputMoney >= junSalary && _inputMoney < middleSalary)
                {
                    totalProductivity = totalProductivity + junProductivity;
                    _inputMoney = _inputMoney - junSalary;
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
