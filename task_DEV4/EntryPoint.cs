using System;

namespace task_DEV4
{
    /// <summary>
    /// Entry point
    /// </summary>
    /// <param name="args">Arguments from command line</param>
    class EntryPoint
    {       
        static void Main(string[] args)
        {
            try
            {
                Discipline discipline = new Discipline();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}

