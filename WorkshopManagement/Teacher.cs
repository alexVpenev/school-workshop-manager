﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagementApp
{
    public class Teacher : Person
    {
        public Teacher(int pcn, string name) : base(pcn, name) { }

        public override string[] GetDisplayInfo()
        {
            return new string[] { base.Pcn.ToString(), base.name, "Teacher" };
        }

    }
}
