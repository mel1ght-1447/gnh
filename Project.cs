using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace pr8
{
    public partial class Project
    {
        public Project()
        {
            ProjectDocument = new HashSet<ProjectDocument>();
            Task = new HashSet<Task>();
        }

        public int PkProject { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Budget { get; set; }
        public string Status { get; set; }
        public int FkUser { get; set; }

        public virtual ICollection<ProjectDocument> ProjectDocument { get; set; }
        public virtual ICollection<Task> Task { get; set; }
    }
}
