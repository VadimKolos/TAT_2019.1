using System;

namespace task_DEV4
{
    class Material : Discipline
    {
        private readonly Guid id;
                
        protected Material()
        {
            this.id = new Guid();
        }
    }
}
