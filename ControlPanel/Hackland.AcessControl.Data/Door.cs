﻿using Hackland.AccessControl.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Hackland.AccessControl.Data
{
    public class Door
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MacAddress { get; set; }
        public DateTime LastHeartbeatTimestamp { get; set; }
        public DateTime? LastReadTimestamp { get; set; }
        public DoorStatus Status { get; set; }
        public bool IsDeleted { get; set; }

        public List<PersonDoor> PersonDoors { get; set; }
    }
}
