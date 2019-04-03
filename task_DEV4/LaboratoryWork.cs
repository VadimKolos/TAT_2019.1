using System;

namespace task_DEV4
{
    /// <summary>
    /// Class Laboratory Work
    /// </summary>
    class LaboratoryWork : Material
    {
        string textDescription { get; set; }
        public LaboratoryWork(string description)
        {
            textDescription = "Laboratory Work";
        }

        /// <summary>
        /// This method returns text description of this object
        /// </summary>
        public override string ToString()
        {
            string description = null;
            if (textDescription.Length > 0 && textDescription.Length < 256)
            {
                description = "Laboratory Work";
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
