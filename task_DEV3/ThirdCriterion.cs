using System;

namespace task_DEV3
{
    /// <summary>
    /// This class create a team be the third criterion. 
    /// </summary>
    public class ThirdCriterion
    {
        Junior constantJuniorParams;
        Middle constantMiddleParams;
        Senior constantSeniorParams;
        Lead constantLeadParams;

        public ThirdCriterion()
        {
            constantJuniorParams = new Junior();
            constantMiddleParams = new Middle();
            constantSeniorParams = new Senior();
            constantLeadParams = new Lead();
        }

        /// <summary>
        /// This method create a team by the third criterion.
        /// </summary>        
        /// <param name="inputProductivity">value of productivity which user was inputed</param>
        /// <param name="employeesArray">array of values about created team and total and count of high qualified employees</param>
        public int[] MinQuantityCalculate(int inputProductivity)
        {
            /// <summary>
            /// Take productivity of each employee.
            /// </summary>
            int middleProductivity = constantMiddleParams.Productivity;
            int seniorProductivity = constantSeniorParams.Productivity;
            int leadProductivity = constantLeadParams.Productivity;

            /// <summary>
            /// Start values of count of employee.
            /// </summary>
            int needCountOfMiddles = 0;
            int needCountOfSeniors = 0;
            int needCountOfLeads = 0;

            int highQualifiedEmployees = 0;

            for (int i = 0; inputProductivity >= middleProductivity; i++)
            {
                if (inputProductivity >= leadProductivity)
                {
                    highQualifiedEmployees++;
                    inputProductivity = inputProductivity - leadProductivity;
                    needCountOfLeads++;
                }
                else if (inputProductivity >= seniorProductivity && inputProductivity < leadProductivity)
                {
                    highQualifiedEmployees++;
                    inputProductivity = inputProductivity - seniorProductivity;
                    needCountOfSeniors++;
                }
                else if (inputProductivity >= middleProductivity && inputProductivity < seniorProductivity)
                {
                    highQualifiedEmployees++;
                    inputProductivity = inputProductivity - middleProductivity;
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
