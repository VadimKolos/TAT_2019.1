using System;

namespace task_DEV5
{
    /// <summary>
    /// This class work with parametres of the bird, plane and space ship.
    /// </summary>
    class Screen
    {
        /// <summary>
        /// This method display flying time of each object.
        /// </summary>
        /// <param name="timeArgument">flying time of some object</param>
        /// <param name="flyingObjectName">name of some object</param>
        public void display(double timeArgument, string flyingObjectName)
        {
            Console.WriteLine("Flight time of " + flyingObjectName + " is: " + timeArgument + " hours");
        }
    }
}

