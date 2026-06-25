using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace pr8
{
    public partial class ProjectDocument
    {
        public int PkProjectDocument { get; set; }
        public string Title { get; set; }
        public int FkProject { get; set; }

        public virtual Project FkProjectNavigation { get; set; }
    }
}
