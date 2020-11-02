namespace System_Test
{
    partial class AddTag
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
            this.label1 = new System.Windows.Forms.Label();
            this.TagName = new System.Windows.Forms.TextBox();
            this.TagTypeSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterAddress = new System.Windows.Forms.TextBox();
            this.CancelTag = new System.Windows.Forms.Button();
            this.SaveTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TagName
            // 
            this.TagName.Location = new System.Drawing.Point(131, 27);
            this.TagName.Name = "TagName";
            this.TagName.Size = new System.Drawing.Size(121, 23);
            this.TagName.TabIndex = 1;
            // 
            // TagTypeSelection
            // 
            this.TagTypeSelection.FormattingEnabled = true;
            this.TagTypeSelection.Items.AddRange(new object[] {
            "Integer (16-bit)",
            "Float",
            "Boolean",
            "Integer (32-bit)"});
            this.TagTypeSelection.Location = new System.Drawing.Point(131, 56);
            this.TagTypeSelection.Name = "TagTypeSelection";
            this.TagTypeSelection.Size = new System.Drawing.Size(121, 23);
            this.TagTypeSelection.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Register Path";
            // 
            // RegisterAddress
            // 
            this.RegisterAddress.Location = new System.Drawing.Point(131, 85);
            this.RegisterAddress.Name = "RegisterAddress";
            this.RegisterAddress.Size = new System.Drawing.Size(121, 23);
            this.RegisterAddress.TabIndex = 1;
            // 
            // CancelTag
            // 
            this.CancelTag.Location = new System.Drawing.Point(211, 130);
            this.CancelTag.Name = "CancelTag";
            this.CancelTag.Size = new System.Drawing.Size(64, 23);
            this.CancelTag.TabIndex = 3;
            this.CancelTag.Text = "Cancel";
            this.CancelTag.UseVisualStyleBackColor = true;
            // 
            // SaveTag
            // 
            this.SaveTag.Location = new System.Drawing.Point(141, 130);
            this.SaveTag.Name = "SaveTag";
            this.SaveTag.Size = new System.Drawing.Size(64, 23);
            this.SaveTag.TabIndex = 3;
            this.SaveTag.Text = "Save";
            this.SaveTag.UseVisualStyleBackColor = true;
            this.SaveTag.Click += new System.EventHandler(this.SaveTag_Click);
            // 
            // AddTag
            // 
            this.AcceptButton = this.SaveTag;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelTag;
            this.ClientSize = new System.Drawing.Size(287, 165);
            this.Controls.Add(this.SaveTag);
            this.Controls.Add(this.CancelTag);
            this.Controls.Add(this.RegisterAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TagTypeSelection);
            this.Controls.Add(this.TagName);
            this.Controls.Add(this.label1);
            this.Name = "AddTag";
            this.Text = "Add Tag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TagName;
        private System.Windows.Forms.ComboBox TagTypeSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegisterAddress;
        private System.Windows.Forms.Button CancelTag;
        private System.Windows.Forms.Button SaveTag;
    }
}