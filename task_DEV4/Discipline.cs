using System;
using System.Collections.Generic;

namespace task_DEV4
{
    class Discipline
    {
        private readonly Guid id;
        public List<Tuple<Lecture, Seminar, LaboratoryWork>> DisciplineList { get; private set; }

        public Discipline()
        {
            this.id = new Guid();
            this.DisciplineList = new List<Tuple<Lecture, Seminar, LaboratoryWork>>();
        }
    }
}
