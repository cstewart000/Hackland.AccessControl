﻿using System;
using System.Collections.Generic;

namespace Hackland.AccessControl.Web.Data
{
    public partial class Userclaim
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual User User { get; set; }
    }
}
