﻿using System;
using System.Collections.Generic;

namespace task_DEV5
{
    /// <summary>
    /// Entry point of the program.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The main - start program.
        /// Start point coordinates  - 0, 0, 0.
        /// End point coordinates  - 100, 200, 800.
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                Screen screen = new Screen();
                Point point = new Point(0, 0, 0);
                int[] coordinateArray;
                var iFly = new List<IFlyable> { new Bird(), new Plane(), new SpaceShip() };

                foreach (var flyable in iFly)
                {
                    coordinateArray = flyable.FlyTo(new Point(100, 200, 800));
                    double timeArgument = flyable.GetFlyTime(coordinateArray);
                    string flyingObjectName = flyable.WhoAmI();
                    screen.display(timeArgument, flyingObjectName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}
