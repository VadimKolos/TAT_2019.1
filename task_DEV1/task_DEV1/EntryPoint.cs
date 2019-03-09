using System;

namespace task_DEV1
{
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
                UniqueSymbols uniquesybols = new UniqueSymbols();                
                uniquesybols.DisplaySubsequence(uniquesybols.SubsequenceFinder(args[0]));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
    }
}

