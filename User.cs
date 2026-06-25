using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace pr8
{
    public partial class User
    {
        public User()
        {
            Report = new HashSet<Report>();
        }

        public int PkUser { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Midllename { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Report> Report { get; set; }
    }
}
