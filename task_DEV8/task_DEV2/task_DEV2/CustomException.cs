using System;

namespace task_DEV2
{
    /// <summary>
    /// This class inherited from class Excepcion
    /// </summary>
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            
        }
    }
}
