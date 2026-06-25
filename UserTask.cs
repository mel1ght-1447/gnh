using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace pr8
{
    public partial class UserTask
    {
        public int FkUser { get; set; }
        public int FkTask { get; set; }

        public virtual Task FkTaskNavigation { get; set; }
        public virtual User FkUserNavigation { get; set; }
    }
}
