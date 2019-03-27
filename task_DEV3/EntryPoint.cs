using System;

namespace task_DEV3
{
    /// <summary>
    /// Entry point
    /// </summary>    
    class EntryPoint
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        static void Main(string[] args)
        {
            try
            {
                if (args[0] == string.Empty || args[1] == string.Empty || args[2] == string.Empty)
                {
                    Console.WriteLine("Incorreсt input:  use 3 parametres");
                    Environment.Exit(1);
                }
                else
                {
                    TeamBuilder optimizer = new TeamBuilder(args[0], args[1], args[2]);
                    optimizer.InputDataTake();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}
