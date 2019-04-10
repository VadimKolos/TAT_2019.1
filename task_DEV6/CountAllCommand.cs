using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV6
{

    /// <summary>
    /// Command that outputs count of cars to console
    /// </summary>
    class CountAllCommand : ICommand
    {
        private Collection Reciver { get; set; }

        public CountAllCommand(Collection reciver)
        {
            Reciver = reciver;
        }

        /// <summary>
        /// Executes command that outputs count of cars to console
        /// </summary>
        public void Execute()
        {
            Console.WriteLine(Reciver.CountAll());
        }
    }
}

