using System;
using System.Collections.Generic;

namespace task_DEV4
{
    class Discipline
    {
        string textDescription { get; set; }

        public Discipline()
        {
            textDescription = "descipline";
        }

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
    }
}
