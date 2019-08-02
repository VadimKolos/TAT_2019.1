using System;

namespace taskDEV3
{
    /// <summary>
    /// This class work with input params and choose a criterion.
    /// </summary>
    public class TeamCreator
    {
        public int _salary { get; set; }
        public int _productivity { get; set; }
        public int _criterion { get; set; }

        ProductivityCriterion firstCriterion = new ProductivityCriterion();
        SalaryCriterion secondCriterion = new SalaryCriterion();
        quantityEmployeeCriterion thirdCriterion = new quantityEmployeeCriterion();
        DisplayerScreen display = new DisplayerScreen();

        public TeamCreator(string salary, string productivity, string criterion)
        {
            _salary = Convert.ToInt32(salary);
            _productivity = Convert.ToInt32(productivity);
            _criterion = Convert.ToInt32(criterion);
        }

        /// <summary>
        /// This method choose a criterion and show the input data.
        /// </summary>       
        public void InputDataTake()
        {
            Console.WriteLine("input salary - " + _salary + ", input productivity - " + _productivity + ", input criterion - " + _criterion);

            if (_criterion == 1)
            {
                int[] employeArray = firstCriterion.MaxProductivityCalculate(_productivity);
                display.ShowFirstCriterion(employeArray);
            }
            if (_criterion == 2)
            {
                int[] employeArray = secondCriterion.MinSalaryCalculate(_productivity);
                display.ShowSecondCriterion(employeArray);
            }
            if (_criterion == 3)
            {
                int[] employeArray = thirdCriterion.MinQuantityCalculate(_productivity);
                display.ShowThirdCriterion(employeArray);
            }
            else
            {
                Console.WriteLine("Incorrect Input of criterion (use 1,2,3)");
            }
        }
    }
}
