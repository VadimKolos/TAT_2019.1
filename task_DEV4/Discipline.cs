using System;

namespace task_DEV4
{
    /// <summary>
    /// Class Discipline
    /// </summary>
    class Discipline
    {
        string textDescription { get; set; }

        public Discipline()
        {
            textDescription = "descipline";
        }

        /// <summary>
        /// This method returns text description of this object
        /// </summary>
        public override string ToString()
        {
            string description = null;
            if (textDescription.Length > 0 && textDescription.Length < 256)
            {
                description = "Discipline";
            }
            if (textDescription == "")
            {
                description = "empty";
            }
            else
            {
                description = "null";
            }
            return description;
        }

        /// <summary>
        /// This method set unique identificator.
        /// </summary>
        public Guid SetGuid()
        {
            Guid guid = Guid.NewGuid();
            return guid;
        }
    }
}
