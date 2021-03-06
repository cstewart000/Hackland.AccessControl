﻿using Hackland.AccessControl.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackland.AccessControl.Web.Models.ViewModels
{
    public class PersonListViewModel
    {
        public IEnumerable<Person> Items { get; set; }
        public bool IsCreateAvailable { get; internal set; }
        public bool IsAssignAvailable { get; internal set; }
    }
}
