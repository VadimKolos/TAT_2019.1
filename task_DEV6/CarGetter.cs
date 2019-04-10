using System;
using System.Collections.Generic;
using System.Linq;
namespace task_DEV6
{
    static class CarGetter
    {
        public static Car GetCarFromConsole()
        {           
            string brand = Console.ReadLine();                     
            string model = Console.ReadLine();                        
            int price = int.Parse(Console.ReadLine());            
            int count = int.Parse(Console.ReadLine());
            return new Car(brand, model, count, price);
        }
    }
}
