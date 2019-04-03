using System;

namespace task_DEV4
{
    /// <summary>
    /// Entry point
    /// </summary>
    /// <param name="args">Arguments from command line</param>
    class EntryPoint
    {       
        static void Main(string[] args)
        {
            try
            {
                Discipline discipline = new Discipline();
                discipline.ToString();

                Material material = new Material();
                material.ToString();
                material.Description();

                Lecture lecture = new Lecture();
                lecture.LectureTextCheck("Lecture text");
                lecture.ToString();
                lecture.GetPresentationFormat("PDF");

                Seminar seminar = new Seminar(1, "task1", "question1", "answer1", "seminar");
                seminar.ToString();
                seminar.Description();

                LaboratoryWork laboratoryWork = new LaboratoryWork("Laboratory work");
                laboratoryWork.ToString();
                laboratoryWork.Description();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}

