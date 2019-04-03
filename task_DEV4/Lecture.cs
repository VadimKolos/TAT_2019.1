namespace task_DEV4
{
    /// <summary>
    /// Class Lecture
    /// </summary>
    class Lecture : Material
    {
        private string lectureText;
        private string presentationFormat;
        string textDescription { get; set; }
        string text { get; set; }
        string URIContent { get; set; }

        public Lecture()
        {
            textDescription = "Lecture";
            text = "Lecture Text";
        }

        /// <summary>
        /// This method returns text description of this object
        /// </summary>
        public override string ToString()
        {
            string description = null;
            if (textDescription.Length > 0 && textDescription.Length < 256)
            {
                description = "Lecture";
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
        /// This method check length of lecture text (maximum length 10000 symbols) 
        /// </summary>
        public string LectureTextCheck(string text)
        {
            if (text.Length <= 100000)
            {
                lectureText = text;
            }
            else
            {
                lectureText = string.Empty;
            }
            return lectureText;
        }

        /// <summary>
        /// This method get presentation format 
        /// </summary>
        public string GetPresentationFormat(string format)
        {
            if (format == "PPT")
            {
                presentationFormat = "PPT";
            }
            if (format == "PDF")
            {
                presentationFormat = "PDF";
            }
            else
            {
                presentationFormat = "unknown";
            }
            return presentationFormat;
        }        
    }
}
