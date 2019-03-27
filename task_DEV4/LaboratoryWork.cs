using System.Collections.Generic;

namespace task_DEV4
{
    class LaboratoryWork : Material
    {
        public LaboratoryWork(List<string> listQuestions, string listMethodics)
        {
            this.ListQuestions = listQuestions;
            this.ListMethodics = listMethodics;
        }
        
        public List<string> ListQuestions { get; private set; }       
        public string ListMethodics { get; private set; }
    }
}
