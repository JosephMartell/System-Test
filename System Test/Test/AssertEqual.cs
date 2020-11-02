using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace System_Test.Test
{
    public class AssertEqual
    {
        public Int16 StartRegister { get; set; }
        public Int16 ExpectedValue { get; set; }

        public bool RunTest(ModbusTCP.MBTCPClient client)
        {
            var actualValues = client.ReadHoldingRegisters(StartRegister, 1);
            for (int i = 0; i < actualValues.Count(); i++)
            {
                if (actualValues.ElementAt(i) != ExpectedValue)
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"Register {StartRegister} should be {ExpectedValue}";
        }
    }

    public class AssertTagEqual
    {
        public string TagName { get; set; }
        public string ExpectedValue { get; set; }
        public override string ToString()
        {
            return $"Tag {TagName} should be {ExpectedValue}";
        }
    }
}
