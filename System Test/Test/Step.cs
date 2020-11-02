using System;
using System.Collections.Generic;
using System.Text;

namespace System_Test.Test
{
    public class Step
    {
        public IEnumerable<WriteTag> TagActions { get; set; } = new List<WriteTag>();
        //public IEnumerable<AssertEqual> Tests { get; set; } = new List<AssertEqual>();
        public IEnumerable<AssertTagEqual> Asserts { get; set; } = new List<AssertTagEqual>();
    }
}
