﻿using System;
using System.Collections.Generic;

namespace Hackland.AccessControl.Web.Data
{
    public partial class Role
    {
        public Role()
        {
            Roleclaim = new HashSet<Roleclaim>();
            Userrole = new HashSet<Userrole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<Roleclaim> Roleclaim { get; set; }
        public virtual ICollection<Userrole> Userrole { get; set; }
    }
}
