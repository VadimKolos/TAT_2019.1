using System;

namespace task_DEV4
{
    /// <summary>
    /// Class Material
    /// </summary>
    class Material : Discipline
    {
        string textDescription { get; set; }


        public string Description()
        {
            textDescription = "Material";
            return textDescription;
        }

        /// <summary>
        /// This method returns text description of this object
        /// </summary>
        public override string ToString()
        {
            string description = null;
            if (textDescription.Length > 0 && textDescription.Length < 256)
            {
                description = "Material";
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
