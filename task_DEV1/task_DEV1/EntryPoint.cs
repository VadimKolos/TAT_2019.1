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
                SubsequenceSearcher subsequenceSearcher = new SubsequenceSearcher(args[0]);
                subsequenceSearcher.DisplaySubsequence(subsequenceSearcher.SubsequenceFinder());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}
