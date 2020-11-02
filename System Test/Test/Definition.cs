using System;
using System.Collections.Generic;
using System.Text;

namespace System_Test.Test
{
    public class Definition
    {
        public string Name { get; set; }
        public List<Step> TestSteps { get; set; } = new List<Step>();
        public bool TestComplete { get; set; } = false;
        public bool TestPass { get; set; } = false;
        public int TickInterval { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
