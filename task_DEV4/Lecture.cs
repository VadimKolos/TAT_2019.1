namespace task_DEV4
{
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

        public string LectureTextCheck()
        {
            if (text.Length <= 100000)
            {
                lectureText = text;
            }
            return lectureText;
        }

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
