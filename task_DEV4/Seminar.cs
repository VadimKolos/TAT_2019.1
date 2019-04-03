using System;
using System.Collections.Generic;

namespace task_DEV4
{
    /// <summary>
    /// Class Seminar
    /// </summary>
    class Seminar : Material
    {
        string textDescription { get; set; }

        Dictionary<string, string> controlQuestions = new Dictionary<string, string>();

        /// <summary>
        /// This method add control questions.
        /// </summary>
        /// <param name="countOfQuestions">count of questions</param>
        /// <param name="task">task in seminar</param>
        /// <param name="question">control question</param>
        /// <param name="answer">Right answer on control question</param>
        public Seminar(int countOfQuestions, string task, string question, string answer, string description )
        {
            textDescription = description;
            var tasks = new HashSet<string>();

            while (countOfQuestions >= 1)
            {
                controlQuestions.Add(question, answer);
                tasks.Add(task);
                countOfQuestions--;
            }
        }

        /// <summary>
        /// This method returns text description of this object
        /// </summary>
        public override string ToString()
        {
            string description = null;
            if (textDescription.Length > 0 && textDescription.Length < 256)
            {
                description = "Seminar";
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
