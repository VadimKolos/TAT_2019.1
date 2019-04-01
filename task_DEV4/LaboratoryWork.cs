using System.Collections.Generic;

namespace task_DEV4
{
    class LaboratoryWork : Material
    {
        string textDescription { get; set; }
        public LaboratoryWork(string description)
        {
            textDescription = "Laboratory Work";
        }

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
    }
}
