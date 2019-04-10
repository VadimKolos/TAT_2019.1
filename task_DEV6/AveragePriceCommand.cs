using System;

namespace task_DEV6
{   
    class AveragePriceCommand : ICommand
    {
        private Collection Reciver { get; set; }

        public AveragePriceCommand(Collection reciver)
        {
            Reciver = reciver;
        }
                
        public void Execute()
        {
            Console.WriteLine(Reciver.AveragePrice());
        }
    }
}
