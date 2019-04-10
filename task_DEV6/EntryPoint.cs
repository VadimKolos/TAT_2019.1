using System;

namespace task_DEV6
{
    class EntryPoint
    {       
        static void Main()
        {
            try
            {
                Collection collection = new Collection();
                CommandFactory commandFactory = new CommandFactory();
                do
                {
                    ICommand command = new AddInCollectionCommand(collection, CarGetter.GetCarFromConsole());
                    command.Execute();                    
                }
                while (Console.ReadLine().ToLower() != "n");

                while (true)
                {
                    Console.WriteLine("Input command");
                    ICommand command = commandFactory.GetCommand(Console.ReadLine(), collection);

                    if (command == null)
                    {
                        break;
                    }

                    command.Execute();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

