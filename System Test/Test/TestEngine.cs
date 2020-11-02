using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System_Test.Comms;

namespace System_Test.Test
{
    public class TestEngine
    {
        public event EventHandler TestCompleteEvent;
        public Device Device { get; }
        public IEnumerable<Definition> Tests { get; }
        public TestEngine(Device device, IEnumerable<Definition> tests)
        {
            Device = device;
            Tests = tests;
        }

        public void ExecuteAllTests()
        {
            if (Tests.Count() > 0)
            {
                ExecuteTestSet(TestQueue(Tests));
            }
        }

        public IEnumerable<Definition> TestQueue(IEnumerable<Definition> tests)
        {
            foreach (var test in tests)
            {
                yield return test;
            }
        }

        private Definition activeTest;
        private int activeStep;
        public void ExecuteTestSet(IEnumerable<Definition> tests)
        {
            foreach (var test in tests)
            {
                ExecuteTest(test);
            }
        }

        public void ExecuteTest(Definition test)
        {
            test.TestComplete = false;
            test.TestPass = true;
            foreach (var step in test.TestSteps)
            {
                ExecuteActions(Device, step.TagActions);
                if (!CheckAsserts(Device, step.Asserts))
                {
                    test.TestComplete = true;
                    test.TestPass = false;
                    break;
                }
                Thread.Sleep(test.TickInterval);
            }
            if (!test.TestComplete)
            {
                test.TestComplete = true;
                test.TestPass = true;
            }
            OnRaiseTestCompleteEvent();
        }

        protected virtual void OnRaiseTestCompleteEvent()
        {
            EventHandler raiseEvent = TestCompleteEvent;
            if (raiseEvent != null)
            {
                raiseEvent(this, new EventArgs());
            }
        }

        private static void ExecuteActions(Device device, IEnumerable<WriteTag> actions)
        {
            foreach (var action in actions)
            {
                if (device.IntegerTags.ContainsKey(action.TagName))
                {
                    device.IntegerTags[action.TagName].Value = Int16.Parse(action.Value);
                }
                else if (device.SingleTags.ContainsKey(action.TagName))
                {
                    device.SingleTags[action.TagName].Value = float.Parse(action.Value);
                }
                else if (device.BoolTags.ContainsKey(action.TagName))
                {
                    device.BoolTags[action.TagName].Value = bool.Parse(action.Value);
                }
            }
        }

        private static bool CheckAsserts(Device device, IEnumerable<AssertTagEqual> asserts)
        {
            foreach (var test in asserts)
            {
                if (device.IntegerTags.ContainsKey(test.TagName))
                {
                    if (device.IntegerTags[test.TagName].Value != Convert.ToInt16(test.ExpectedValue))
                    {
                        return false;
                    }
                }
                else if (device.SingleTags.ContainsKey(test.TagName))
                {
                    float expectedValue = Convert.ToSingle(test.ExpectedValue);
                    float highLimit = expectedValue * 1.01f;
                    float lowLimit = expectedValue * 0.99f;
                    float currentValue = device.SingleTags[test.TagName].Value;
                    if ((currentValue > highLimit) || (currentValue < lowLimit))
                    {
                        return false;
                    }
                }
                else if (device.BoolTags.ContainsKey(test.TagName))
                {

                    if (device.BoolTags[test.TagName].Value != Convert.ToBoolean(test.ExpectedValue))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
