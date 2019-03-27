using System;

namespace task_DEV3
{
    /// <summary>
    /// This class create a team be the third criterion. 
    /// </summary>
    class ThirdCriterion
    {
        Junior constJuniorParams;
        Middle constMiddleParams;
        Senior constSeniorParams;
        Lead constLeadParams;

        public ThirdCriterion()
        {
            constJuniorParams = new Junior();
            constMiddleParams = new Middle();
            constSeniorParams = new Senior();
            constLeadParams = new Lead();
        }

        /// <summary>
        /// This method create a team by the third criterion.
        /// </summary>        
        /// <param name="_inputProductivity">value of productivity which user was inputed</param>
        /// <param name="employeesArray">array of values about created team and total and count of high qualified employees</param>
        public int[] MinQuantityCalculate(int _inputProductivity)
        {
            /// <summary>
            /// Take productivity of each employee.
            /// </summary>
            int middleProductivity = constMiddleParams.Productivity;
            int seniorProductivity = constSeniorParams.Productivity;
            int leadProductivity = constLeadParams.Productivity;

            /// <summary>
            /// Start values of count of employee.
            /// </summary>
            int needCountOfMiddles = 0;
            int needCountOfSeniors = 0;
            int needCountOfLeads = 0;
            int highQualifiedEmployees = 0;
            for (int i = 0; _inputProductivity >= middleProductivity; i++)
            {
                if (_inputProductivity >= leadProductivity)
                {
                    highQualifiedEmployees++;
                    _inputProductivity = _inputProductivity - leadProductivity;
                    needCountOfLeads++;
                }
                else if (_inputProductivity >= seniorProductivity && _inputProductivity < leadProductivity)
                {
                    highQualifiedEmployees++;
                    _inputProductivity = _inputProductivity - seniorProductivity;
                    needCountOfSeniors++;
                }
                else if (_inputProductivity >= middleProductivity && _inputProductivity < seniorProductivity)
                {
                    highQualifiedEmployees++;
                    _inputProductivity = _inputProductivity - middleProductivity;
                    needCountOfMiddles++;
                }
                else
                {
                    Console.WriteLine("Not enogh employees");
                    break;
                }
            }
            int[] employeesArray = { needCountOfMiddles, needCountOfSeniors, needCountOfLeads, highQualifiedEmployees };
            return employeesArray;
        }
    }
}
