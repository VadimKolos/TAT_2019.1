using System;

namespace task_DEV2
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
                PhoneticConverter phoneticConverter = new PhoneticConverter(args[0]);
                phoneticConverter.PhonemsConverter(args[0], phoneticConverter.ShockVowelSearcher(args[0]));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}