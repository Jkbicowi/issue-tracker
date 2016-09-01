﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARUP.IssueTracker.Navisworks
{
    public class Plane
    {
        public string Type { get; set; }
        public int Version { get; set; }
        public List<int> Normal { get; set; }
        public double Distance { get; set; }
        public bool Enabled { get; set; }
    }

    public class NWClippingPlanes
    {
        public string Type { get; set; }
        public int Version { get; set; }
        public List<Plane> Planes { get; set; }
        public bool Linked { get; set; }
        public bool Enabled { get; set; }
    }

}
