using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace pr8
{
    public partial class SystemSetting
    {
        public int PkSystemSetting { get; set; }
        public string BackupType { get; set; }
        public DateTime BackupDate { get; set; }
    }
}
