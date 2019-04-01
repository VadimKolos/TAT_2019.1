using System.Collections.Generic;


namespace task_DEV4
{
    class Seminar : Material
    {
        string textDescription { get; set; }

        Dictionary<string, string> controlQuestions = new Dictionary<string, string>();
       
        public Seminar(int countOfQuestions, string task, string question, string answer, string description )
        {
            textDescription = "seminar";
            var tasks = new HashSet<string>();

            while (countOfQuestions >= 1)
            {
                controlQuestions.Add(question, answer);
                tasks.Add(task);
                countOfQuestions--;
            }
        }

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

    }
}
