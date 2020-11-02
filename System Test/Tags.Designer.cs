namespace System_Test
{
    partial class Tags
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTagName = new System.Windows.Forms.ColumnHeader();
            this.colPath = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTag = new System.Windows.Forms.Button();
            this.DeleteTag = new System.Windows.Forms.Button();
            this.editTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTagName,
            this.colPath});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(363, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colTagName
            // 
            this.colTagName.Text = "Tag Name";
            this.colTagName.Width = 200;
            // 
            // colPath
            // 
            this.colPath.Text = "Path";
            this.colPath.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tags";
            // 
            // AddTag
            // 
            this.AddTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTag.Location = new System.Drawing.Point(381, 42);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(103, 26);
            this.AddTag.TabIndex = 2;
            this.AddTag.Text = "Add New Tag";
            this.AddTag.UseVisualStyleBackColor = true;
            this.AddTag.Click += new System.EventHandler(this.AddTag_Click);
            // 
            // DeleteTag
            // 
            this.DeleteTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTag.Location = new System.Drawing.Point(381, 106);
            this.DeleteTag.Name = "DeleteTag";
            this.DeleteTag.Size = new System.Drawing.Size(103, 26);
            this.DeleteTag.TabIndex = 2;
            this.DeleteTag.Text = "Delete Tag";
            this.DeleteTag.UseVisualStyleBackColor = true;
            this.DeleteTag.Click += new System.EventHandler(this.DeleteTag_Click);
            // 
            // editTag
            // 
            this.editTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editTag.Location = new System.Drawing.Point(381, 74);
            this.editTag.Name = "editTag";
            this.editTag.Size = new System.Drawing.Size(103, 26);
            this.editTag.TabIndex = 2;
            this.editTag.Text = "Edit Selected Tag";
            this.editTag.UseVisualStyleBackColor = true;
            this.editTag.Click += new System.EventHandler(this.editTag_Click);
            // 
            // Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 414);
            this.Controls.Add(this.editTag);
            this.Controls.Add(this.DeleteTag);
            this.Controls.Add(this.AddTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Tags";
            this.Text = "Tags";
            this.Load += new System.EventHandler(this.Tags_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTag;
        private System.Windows.Forms.Button DeleteTag;
        private System.Windows.Forms.ColumnHeader colTagName;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.Button editTag;
    }
}