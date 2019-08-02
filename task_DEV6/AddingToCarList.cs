using System.Collections.Generic;

namespace Task_DEV5
{
    /// <summary>
    /// Class AddingToCarList for repeatyng input cars in list.
    /// </summary>
    class AddingToCarList
    {
        /// <summary>
        /// Method AddingCarsToList repeat request to add cars.
        /// </summary>
        public CarList AddingCarsToList()
        {
            List<Car> listOfCars = new List<Car>();
            CarList carList = new CarList();
            Car car = new Car();
            carList.AddToCarList(car, listOfCars);

            return carList;
        }
    }
}