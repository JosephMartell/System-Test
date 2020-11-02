using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System_Test.Comms;

namespace System_Test
{
    public partial class TestSetup : Form
    {
        public Test.Definition TestDefinition { get; private set; }
        List<BindingList<Test.WriteTag>> StepActions = new List<BindingList<Test.WriteTag>>();
        List<BindingList<Test.AssertTagEqual>> StepAsserts = new List<BindingList<Test.AssertTagEqual>>();

        public TestSetup()
        {
            InitializeComponent();
            StepActions.Add(new BindingList<Test.WriteTag>());
            Actions.DataSource = StepActions[0];
            StepAsserts.Add(new BindingList<Test.AssertTagEqual>());
            Asserts.DataSource = StepAsserts[0];
            UpdateTagLists();
        }

        public TestSetup(Test.Definition definition)
        {
            InitializeComponent();
            TestDefinition = definition;
            Interval.Value = definition.TickInterval;
            testStepCount.Value = definition.TestSteps.Count;
            StepActions.Clear();
            StepAsserts.Clear();
            for (int i = 0; i < definition.TestSteps.Count; i++)
            {
                var actions = new BindingList<Test.WriteTag>();
                definition.TestSteps[i].TagActions.ToList().ForEach(actions.Add);
                StepActions.Add(actions);

                var tests = new BindingList<Test.AssertTagEqual>();
                definition.TestSteps[i].Asserts.ToList().ForEach(tests.Add);
                StepAsserts.Add(tests);
            }
            Actions.DataSource = StepActions[0];
            Asserts.DataSource = StepAsserts[0];
            TestName.Text = definition.Name;
            UpdateTagLists();
        }

        private void UpdateTagLists()
        {
            comboBox1.Items.AddRange(DeviceFactory.GetDevice("VM Test").IntegerTags.Select(t => t.Value).ToArray());
            comboBox1.Items.AddRange(DeviceFactory.GetDevice("VM Test").SingleTags.Select(t => t.Value).ToArray());
            comboBox1.Items.AddRange(DeviceFactory.GetDevice("VM Test").BoolTags.Select(t => t.Value).ToArray());
            comboBox1.Items.AddRange(DeviceFactory.GetDevice("VM Test").LongTags.Select(t => t.Value).ToArray());

            TestTagSelection.Items.AddRange(DeviceFactory.GetDevice("VM Test").IntegerTags.Select(t => t.Value).ToArray());
            TestTagSelection.Items.AddRange(DeviceFactory.GetDevice("VM Test").SingleTags.Select(t => t.Value).ToArray());
            TestTagSelection.Items.AddRange(DeviceFactory.GetDevice("VM Test").BoolTags.Select(t => t.Value).ToArray());
            TestTagSelection.Items.AddRange(DeviceFactory.GetDevice("VM Test").LongTags.Select(t => t.Value).ToArray());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numOfSteps = Convert.ToInt32(testStepCount.Value);
            trackBar1.Maximum = numOfSteps - 1;
            CurrentStep.Maximum = numOfSteps - 1;
            while (StepActions.Count <= numOfSteps)
            {
                StepActions.Add(new BindingList<Test.WriteTag>());
            }

            if (StepActions.Count > numOfSteps)
                StepActions = StepActions.Take(numOfSteps).ToList();

            while (StepAsserts.Count <= numOfSteps)
            {
                StepAsserts.Add(new BindingList<Test.AssertTagEqual>());
            }

            if (StepAsserts.Count > numOfSteps)
                StepAsserts = StepAsserts.Take(numOfSteps).ToList();
        }

        private void SaveSetup_Click(object sender, EventArgs e)
        {
            var def = new Test.Definition();
            def.Name = TestName.Text;
            List<Test.Step> steps = new List<Test.Step>();

            for (int i = 0; i < testStepCount.Value; i++)
            {
                steps.Add(new Test.Step()
                {
                    TagActions = StepActions[i].ToList(),
                    Asserts = StepAsserts[i].ToList()

                }) ;
            }
            def.TestSteps = steps;
            def.TickInterval = Convert.ToInt32(Interval.Value);
            TestDefinition = def;
            this.DialogResult = DialogResult.OK;
        }

        private void CurrentStep_ValueChanged(object sender, EventArgs e)
        {
            Actions.DataSource = StepActions[Convert.ToInt32(CurrentStep.Value)];
            Asserts.DataSource = StepAsserts[Convert.ToInt32(CurrentStep.Value)];
        }

        private void CancelSetup_Click(object sender, EventArgs e)
        {
            TestDefinition = null;
            this.Close();
        }

        private void AddAction_Click(object sender, EventArgs e)
        {
            var currentStep = Convert.ToInt32(CurrentStep.Value);
            var action = new Test.WriteTag();
            action.TagName = comboBox1.SelectedItem.ToString();
            action.Value = ValueToWrite.Text;
            StepActions[currentStep].Add(action);
        }

        private void AddTest_Click(object sender, EventArgs e)
        {
            var currentStep = Convert.ToInt32(CurrentStep.Value);
            var assert = new Test.AssertTagEqual();
            assert.TagName = TestTagSelection.SelectedItem.ToString();
            assert.ExpectedValue = ExpectedValue.Text;

            StepAsserts[currentStep].Add(assert);
        }

        private void DelAction_Click(object sender, EventArgs e)
        {
            if (Actions.SelectedItems.Count > 0)
            {
                var currentStep = Convert.ToInt32(CurrentStep.Value);
                StepActions[currentStep].Remove((Test.WriteTag)Actions.SelectedItems[0]);
            }
        }

        private void DelAssert_Click(object sender, EventArgs e)
        {
            if (Asserts.SelectedItems.Count > 0)
            {
                var currentStep = Convert.ToInt32(CurrentStep.Value);
                StepAsserts[currentStep].Remove((Test.AssertTagEqual)Asserts.SelectedItems[0]);
            }
        }
    }
}
