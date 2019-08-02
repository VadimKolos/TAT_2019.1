using System;

namespace task_DEV1
{
    /// <summary>
    /// This program search unique subsequences from input string
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
                SubsequenceSearch subsequenceSearcher = new SubsequenceSearch(args[0]);
                subsequenceSearcher.DisplaySubsequence(subsequenceSearcher.SubsequenceFind());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}