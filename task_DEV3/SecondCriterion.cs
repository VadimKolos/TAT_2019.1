using System;

namespace task_DEV3
{
    /// <summary>
    /// This class create a team be the second criterion. 
    /// </summary>
    class SecondCriterion
    {
        Junior constJuniorParams;
        Middle constMiddleParams;
        Senior constSeniorParams;
        Lead constLeadParams;

        public SecondCriterion()
        {
            constJuniorParams = new Junior();
            constMiddleParams = new Middle();
            constSeniorParams = new Senior();
            constLeadParams = new Lead();
        }

        /// <summary>
        /// This method create a team by the second criterion.
        /// </summary>        
        /// <param name="_inputProductivity">value of productivity which user was inputed</param>
        /// <param name="employeesArray">array of values about created team and total Salary</param>
        public int[] MinSalaryCalculate(int _inputProductivity)
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
            int totalSalary = 0;
            for (int i = 0; _inputProductivity >= junProductivity; i++)
            {
                if (_inputProductivity >= leadProductivity)
                {
                    totalSalary = totalSalary + leadSalary;
                    _inputProductivity = _inputProductivity - leadProductivity;
                    needCountOfLeads++;
                }
                else if (_inputProductivity >= seniorProductivity && _inputProductivity < leadProductivity)
                {
                    totalSalary = totalSalary + seniorSalary;
                    _inputProductivity = _inputProductivity - seniorProductivity;
                    needCountOfSeniors++;
                }
                else if (_inputProductivity >= middleProductivity && _inputProductivity < seniorProductivity)
                {
                    totalSalary = totalSalary + middleSalary;
                    _inputProductivity = _inputProductivity - middleProductivity;
                    needCountOfMiddles++;
                }
                else if (_inputProductivity >= junProductivity && _inputProductivity < middleProductivity)
                {
                    totalSalary = totalSalary + junSalary;
                    _inputProductivity = _inputProductivity - junProductivity;
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
