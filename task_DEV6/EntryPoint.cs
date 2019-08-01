using System;

namespace Task_DEV5
{
    /// <summary>
    /// Class CarsCatalog is an entry point in the program.
    /// </summary>
    class CarsCatalog
    {
        static void Main(string[] args)
        {
            try
            {
                Controller controller = new Controller();
                AddingToCarList addingToCars = new AddingToCarList();
                controller.MethodsControll(addingToCars.AddingCarsToList());
            }
            catch (Exception)
            {
                Console.WriteLine("incorrect path of file");
            }
        }
    }
}
