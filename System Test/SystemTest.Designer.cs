namespace System_Test
{
    partial class SystemTest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.TickCount = new System.Windows.Forms.Label();
            this.PlayAllTests = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeleteTestButton = new System.Windows.Forms.Button();
            this.EditTest = new System.Windows.Forms.Button();
            this.AddTestBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.CommsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CommsMenuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.CommsMenuTags = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TestName = new System.Windows.Forms.ColumnHeader();
            this.PlaySelectedTests = new System.Windows.Forms.Button();
            this.testsInProgress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tick Count";
            // 
            // TickCount
            // 
            this.TickCount.AutoSize = true;
            this.TickCount.Location = new System.Drawing.Point(90, 24);
            this.TickCount.Name = "TickCount";
            this.TickCount.Size = new System.Drawing.Size(13, 15);
            this.TickCount.TabIndex = 3;
            this.TickCount.Text = "0";
            // 
            // PlayAllTests
            // 
            this.PlayAllTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayAllTests.Location = new System.Drawing.Point(12, 584);
            this.PlayAllTests.Name = "PlayAllTests";
            this.PlayAllTests.Size = new System.Drawing.Size(91, 35);
            this.PlayAllTests.TabIndex = 4;
            this.PlayAllTests.Text = "Play All Tests";
            this.PlayAllTests.UseVisualStyleBackColor = true;
            this.PlayAllTests.Click += new System.EventHandler(this.PlayAllTests_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(232, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(329, 584);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DeleteTestButton
            // 
            this.DeleteTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTestButton.Location = new System.Drawing.Point(649, 134);
            this.DeleteTestButton.Name = "DeleteTestButton";
            this.DeleteTestButton.Size = new System.Drawing.Size(50, 27);
            this.DeleteTestButton.TabIndex = 7;
            this.DeleteTestButton.Text = "Delete";
            this.DeleteTestButton.UseVisualStyleBackColor = true;
            this.DeleteTestButton.Click += new System.EventHandler(this.DeleteTestButton_Click);
            // 
            // EditTest
            // 
            this.EditTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditTest.Location = new System.Drawing.Point(649, 101);
            this.EditTest.Name = "EditTest";
            this.EditTest.Size = new System.Drawing.Size(50, 27);
            this.EditTest.TabIndex = 7;
            this.EditTest.Text = "Edit";
            this.EditTest.UseVisualStyleBackColor = true;
            this.EditTest.Click += new System.EventHandler(this.EditTest_Click);
            // 
            // AddTestBtn
            // 
            this.AddTestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTestBtn.Location = new System.Drawing.Point(649, 68);
            this.AddTestBtn.Name = "AddTestBtn";
            this.AddTestBtn.Size = new System.Drawing.Size(50, 27);
            this.AddTestBtn.TabIndex = 7;
            this.AddTestBtn.Text = "Add";
            this.AddTestBtn.UseVisualStyleBackColor = true;
            this.AddTestBtn.Click += new System.EventHandler(this.AddTest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.CommsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "TopMenu";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuOpen,
            this.FileMenuSave,
            this.toolStripSeparator1,
            this.FileMenuExit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "&File";
            // 
            // FileMenuOpen
            // 
            this.FileMenuOpen.Name = "FileMenuOpen";
            this.FileMenuOpen.Size = new System.Drawing.Size(103, 22);
            this.FileMenuOpen.Text = "&Open";
            this.FileMenuOpen.Click += new System.EventHandler(this.FileMenuOpen_Click);
            // 
            // FileMenuSave
            // 
            this.FileMenuSave.Name = "FileMenuSave";
            this.FileMenuSave.Size = new System.Drawing.Size(103, 22);
            this.FileMenuSave.Text = "&Save";
            this.FileMenuSave.Click += new System.EventHandler(this.FileMenuSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // FileMenuExit
            // 
            this.FileMenuExit.Name = "FileMenuExit";
            this.FileMenuExit.Size = new System.Drawing.Size(103, 22);
            this.FileMenuExit.Text = "E&xit";
            this.FileMenuExit.Click += new System.EventHandler(this.FileMenuExit_Click);
            // 
            // CommsMenu
            // 
            this.CommsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CommsMenuManage,
            this.CommsMenuTags});
            this.CommsMenu.Name = "CommsMenu";
            this.CommsMenu.Size = new System.Drawing.Size(61, 20);
            this.CommsMenu.Text = "Comms";
            // 
            // CommsMenuManage
            // 
            this.CommsMenuManage.Name = "CommsMenuManage";
            this.CommsMenuManage.Size = new System.Drawing.Size(154, 22);
            this.CommsMenuManage.Text = "Mange Devices";
            this.CommsMenuManage.Click += new System.EventHandler(this.CommsMenuManage_Click);
            // 
            // CommsMenuTags
            // 
            this.CommsMenuTags.Name = "CommsMenuTags";
            this.CommsMenuTags.Size = new System.Drawing.Size(154, 22);
            this.CommsMenuTags.Text = "Tags";
            this.CommsMenuTags.Click += new System.EventHandler(this.CommsMenuTags_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Available Tests";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TestName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(620, 489);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // TestName
            // 
            this.TestName.Text = "Test Name";
            this.TestName.Width = 290;
            // 
            // PlaySelectedTests
            // 
            this.PlaySelectedTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlaySelectedTests.Location = new System.Drawing.Point(109, 584);
            this.PlaySelectedTests.Name = "PlaySelectedTests";
            this.PlaySelectedTests.Size = new System.Drawing.Size(117, 35);
            this.PlaySelectedTests.TabIndex = 4;
            this.PlaySelectedTests.Text = "Play Selected Tests";
            this.PlaySelectedTests.UseVisualStyleBackColor = true;
            this.PlaySelectedTests.Click += new System.EventHandler(this.PlaySelectedTests_Click);
            // 
            // testsInProgress
            // 
            this.testsInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testsInProgress.Location = new System.Drawing.Point(12, 563);
            this.testsInProgress.Name = "testsInProgress";
            this.testsInProgress.Size = new System.Drawing.Size(620, 15);
            this.testsInProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.testsInProgress.TabIndex = 12;
            // 
            // SystemTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 631);
            this.Controls.Add(this.testsInProgress);
            this.Controls.Add(this.PlaySelectedTests);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddTestBtn);
            this.Controls.Add(this.EditTest);
            this.Controls.Add(this.DeleteTestButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PlayAllTests);
            this.Controls.Add(this.TickCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SystemTest";
            this.Text = "System Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemTest_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TickCount;
        private System.Windows.Forms.Button PlaySelectedTests;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DeleteTestButton;
        private System.Windows.Forms.Button EditTest;
        private System.Windows.Forms.Button AddTestBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem CommsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuExit;
        private System.Windows.Forms.ToolStripMenuItem CommsMenuManage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TestName;
        private System.Windows.Forms.ToolStripMenuItem FileMenuSave;
        private System.Windows.Forms.ToolStripMenuItem FileMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem DevicesMenuManage;
        private System.Windows.Forms.ToolStripMenuItem CommsMenuTags;
        private System.Windows.Forms.Button PlayAllTests;
        private System.Windows.Forms.ProgressBar testsInProgress;
    }
}

