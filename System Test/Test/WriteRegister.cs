using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace System_Test.Test
{
    public class WriteRegister
    {
        public Int16 Register { get; set; }
        public Int16 Value { get; set; }

        public override string ToString()
        {
            return $"Set {Register} to {Value}";
        }
    }

    public class WriteTag
    {
        public string TagName { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"Set {TagName} to {Value}";
        }
    }
}
