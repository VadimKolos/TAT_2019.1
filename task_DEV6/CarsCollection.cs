using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV6
{
    class Collection
    {
        private List<Car> Cars { get; set; }
        public void AddInCollection(Car car)
        {
            Car tempCar = Cars.Find(x => x.Brand == car.Brand && x.Model == car.Model);

            if (tempCar != null)
            {
                if (tempCar.Price == car.Price)
                {
                    tempCar.Count += car.Count;
                }
                else
                {
                    throw new Exception("Incorrect car input");
                }
            }
            else
            {
                if (car.Price <= 0 || car.Count <= 0)
                {
                    throw new Exception("Incorrect car input");
                }
                Cars.Add(car);
            }
        }
       
        public double AveragePrice()
        {
            return Cars.Average(x => x.Price);
        }
        
        public double AveragePriceType(string brand)
        {
            brand = brand.ToLower();
            return Cars.Where(x => x.Brand.ToLower() == brand).Average(x => x.Price);
        }
        
        public int CountAll()
        {
            return Cars.Sum(x => x.Count);
        }
               
        public int CountTypes()
        {
            return Cars.GroupBy(x => x.Brand).Count();
        }

        public Collection()
        {
            Cars = new List<Car>();
        }
    }
}

