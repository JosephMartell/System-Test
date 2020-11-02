namespace System_Test
{
    partial class TestSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TestName = new System.Windows.Forms.TextBox();
            this.testStepCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentStep = new System.Windows.Forms.NumericUpDown();
            this.Actions = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Asserts = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddAction = new System.Windows.Forms.Button();
            this.DelAction = new System.Windows.Forms.Button();
            this.AddTest = new System.Windows.Forms.Button();
            this.DelAssert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ValueToWrite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ExpectedValue = new System.Windows.Forms.TextBox();
            this.SaveSetup = new System.Windows.Forms.Button();
            this.CancelSetup = new System.Windows.Forms.Button();
            this.Interval = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TestTagSelection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testStepCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 122);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(619, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Name";
            // 
            // TestName
            // 
            this.TestName.Location = new System.Drawing.Point(87, 12);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(173, 23);
            this.TestName.TabIndex = 2;
            // 
            // testStepCount
            // 
            this.testStepCount.Location = new System.Drawing.Point(87, 41);
            this.testStepCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.testStepCount.Name = "testStepCount";
            this.testStepCount.Size = new System.Drawing.Size(97, 23);
            this.testStepCount.TabIndex = 3;
            this.testStepCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.testStepCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Step Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Current Step";
            // 
            // CurrentStep
            // 
            this.CurrentStep.Location = new System.Drawing.Point(87, 91);
            this.CurrentStep.Name = "CurrentStep";
            this.CurrentStep.Size = new System.Drawing.Size(97, 23);
            this.CurrentStep.TabIndex = 3;
            this.CurrentStep.ValueChanged += new System.EventHandler(this.CurrentStep_ValueChanged);
            // 
            // Actions
            // 
            this.Actions.FormattingEnabled = true;
            this.Actions.ItemHeight = 15;
            this.Actions.Location = new System.Drawing.Point(12, 245);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(301, 184);
            this.Actions.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Actions";
            // 
            // Asserts
            // 
            this.Asserts.FormattingEnabled = true;
            this.Asserts.ItemHeight = 15;
            this.Asserts.Location = new System.Drawing.Point(319, 245);
            this.Asserts.Name = "Asserts";
            this.Asserts.Size = new System.Drawing.Size(312, 184);
            this.Asserts.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tests";
            // 
            // AddAction
            // 
            this.AddAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAction.Location = new System.Drawing.Point(151, 173);
            this.AddAction.Name = "AddAction";
            this.AddAction.Size = new System.Drawing.Size(50, 27);
            this.AddAction.TabIndex = 7;
            this.AddAction.Text = "Add";
            this.AddAction.UseVisualStyleBackColor = true;
            this.AddAction.Click += new System.EventHandler(this.AddAction_Click);
            // 
            // DelAction
            // 
            this.DelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelAction.Location = new System.Drawing.Point(263, 173);
            this.DelAction.Name = "DelAction";
            this.DelAction.Size = new System.Drawing.Size(50, 27);
            this.DelAction.TabIndex = 7;
            this.DelAction.Text = "Delete";
            this.DelAction.UseVisualStyleBackColor = true;
            this.DelAction.Click += new System.EventHandler(this.DelAction_Click);
            // 
            // AddTest
            // 
            this.AddTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTest.Location = new System.Drawing.Point(469, 173);
            this.AddTest.Name = "AddTest";
            this.AddTest.Size = new System.Drawing.Size(50, 27);
            this.AddTest.TabIndex = 7;
            this.AddTest.Text = "Add";
            this.AddTest.UseVisualStyleBackColor = true;
            this.AddTest.Click += new System.EventHandler(this.AddTest_Click);
            // 
            // DelAssert
            // 
            this.DelAssert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelAssert.Location = new System.Drawing.Point(581, 173);
            this.DelAssert.Name = "DelAssert";
            this.DelAssert.Size = new System.Drawing.Size(50, 27);
            this.DelAssert.TabIndex = 7;
            this.DelAssert.Text = "Delete";
            this.DelAssert.UseVisualStyleBackColor = true;
            this.DelAssert.Click += new System.EventHandler(this.DelAssert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tag";
            // 
            // ValueToWrite
            // 
            this.ValueToWrite.Location = new System.Drawing.Point(253, 216);
            this.ValueToWrite.Name = "ValueToWrite";
            this.ValueToWrite.Size = new System.Drawing.Size(60, 23);
            this.ValueToWrite.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Expected Value";
            // 
            // ExpectedValue
            // 
            this.ExpectedValue.Location = new System.Drawing.Point(571, 216);
            this.ExpectedValue.Name = "ExpectedValue";
            this.ExpectedValue.Size = new System.Drawing.Size(60, 23);
            this.ExpectedValue.TabIndex = 2;
            // 
            // SaveSetup
            // 
            this.SaveSetup.Location = new System.Drawing.Point(453, 464);
            this.SaveSetup.Name = "SaveSetup";
            this.SaveSetup.Size = new System.Drawing.Size(75, 23);
            this.SaveSetup.TabIndex = 8;
            this.SaveSetup.Text = "Save";
            this.SaveSetup.UseVisualStyleBackColor = true;
            this.SaveSetup.Click += new System.EventHandler(this.SaveSetup_Click);
            // 
            // CancelSetup
            // 
            this.CancelSetup.Location = new System.Drawing.Point(555, 464);
            this.CancelSetup.Name = "CancelSetup";
            this.CancelSetup.Size = new System.Drawing.Size(75, 23);
            this.CancelSetup.TabIndex = 9;
            this.CancelSetup.Text = "Cancel";
            this.CancelSetup.UseVisualStyleBackColor = true;
            this.CancelSetup.Click += new System.EventHandler(this.CancelSetup_Click);
            // 
            // Interval
            // 
            this.Interval.Location = new System.Drawing.Point(276, 41);
            this.Interval.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(97, 23);
            this.Interval.TabIndex = 3;
            this.Interval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Interval.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Interval";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tag";
            // 
            // TestTagSelection
            // 
            this.TestTagSelection.FormattingEnabled = true;
            this.TestTagSelection.Location = new System.Drawing.Point(350, 216);
            this.TestTagSelection.Name = "TestTagSelection";
            this.TestTagSelection.Size = new System.Drawing.Size(131, 23);
            this.TestTagSelection.TabIndex = 10;
            // 
            // TestSetup
            // 
            this.AcceptButton = this.SaveSetup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelSetup;
            this.ClientSize = new System.Drawing.Size(642, 504);
            this.Controls.Add(this.TestTagSelection);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.CancelSetup);
            this.Controls.Add(this.SaveSetup);
            this.Controls.Add(this.ExpectedValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ValueToWrite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DelAssert);
            this.Controls.Add(this.AddTest);
            this.Controls.Add(this.DelAction);
            this.Controls.Add(this.AddAction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Asserts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.CurrentStep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testStepCount);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "TestSetup";
            this.Text = "TestSetup";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testStepCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TestName;
        private System.Windows.Forms.NumericUpDown testStepCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CurrentStep;
        private System.Windows.Forms.ListBox Actions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Asserts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddAction;
        private System.Windows.Forms.Button DelAction;
        private System.Windows.Forms.Button AddTest;
        private System.Windows.Forms.Button DelAssert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ValueToWrite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ExpectedValue;
        private System.Windows.Forms.Button SaveSetup;
        private System.Windows.Forms.Button CancelSetup;
        private System.Windows.Forms.NumericUpDown Interval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TestTagSelection;
    }
}