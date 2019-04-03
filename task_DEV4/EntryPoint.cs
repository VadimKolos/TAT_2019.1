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
                discipline.SetGuid();

                Material material = new Material();
                material.ToString();
                material.Description();
                material.SetGuid();

                Lecture lecture = new Lecture();
                lecture.LectureTextCheck("Lecture text");
                lecture.ToString();
                lecture.GetPresentationFormat("PDF");
                lecture.SetGuid();

                Seminar seminar = new Seminar(1, "task1", "question1", "answer1", "seminar");
                seminar.ToString();
                seminar.Description();
                seminar.SetGuid();

                LaboratoryWork laboratoryWork = new LaboratoryWork("Laboratory work");
                laboratoryWork.ToString();
                laboratoryWork.Description();
                laboratoryWork.SetGuid();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}

