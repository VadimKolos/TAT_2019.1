using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV5
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Point point = new Point(0,0,0);
            var iFly = new List<IFlyable> {new Bird(), new Plane(), new SpaceShip() };
            foreach (var flyable in iFly)
            {              
                flyable.FlyTo(new Point(100, 200, 800));
            }            
        }
    }
}
