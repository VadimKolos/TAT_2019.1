using System;

namespace task_DEV4
{
     class Material : Discipline
    {
        
        string textDescription { get; set; }

        public string Description()
        {
            textDescription = "Material";
            return textDescription;
        }

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
    }
}
