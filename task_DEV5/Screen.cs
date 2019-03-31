using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV5
{
    class Screen
    {
        public void display(double timeArgument, string flyingObjectName)
        {
            Console.WriteLine("flight time of " + flyingObjectName + " is: " + timeArgument);
        }
    }
}

