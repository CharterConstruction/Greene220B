using System;
using System.Collections.Generic;

namespace ITProjectsDB
{
    public partial class Project
    {
        public Project()
        {
            Purpose = new HashSet<Purpose>();
            Scope = new HashSet<Scope>();
            Tasks = new HashSet<Tasks>();
        }

        public int ProjectKey { get; set; }
        public string ProjectName { get; set; }
        public string ProjectConcept { get; set; }
        public int StageKey { get; set; }
        public int StatusKey { get; set; }

        public virtual Stage StageKeyNavigation { get; set; }
        public virtual Status StatusKeyNavigation { get; set; }
        public virtual ICollection<Purpose> Purpose { get; set; }
        public virtual ICollection<Scope> Scope { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
