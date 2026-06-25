using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace pr8
{
    public partial class Report
    {
        public int PkReport { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
        public int FkUser { get; set; }

        public virtual User FkUserNavigation { get; set; }
    }
}
