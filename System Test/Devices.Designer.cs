namespace System_Test
{
    partial class Devices
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
            this.label3 = new System.Windows.Forms.Label();
            this.IPAddressEntry = new System.Windows.Forms.TextBox();
            this.PortField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Devices Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP Address";
            // 
            // IPAddressEntry
            // 
            this.IPAddressEntry.Location = new System.Drawing.Point(88, 45);
            this.IPAddressEntry.Name = "IPAddressEntry";
            this.IPAddressEntry.Size = new System.Drawing.Size(115, 23);
            this.IPAddressEntry.TabIndex = 4;
            // 
            // PortField
            // 
            this.PortField.Location = new System.Drawing.Point(88, 74);
            this.PortField.Name = "PortField";
            this.PortField.Size = new System.Drawing.Size(115, 23);
            this.PortField.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(88, 129);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(75, 23);
            this.SaveChanges.TabIndex = 2;
            this.SaveChanges.Text = "Save";
            this.SaveChanges.UseVisualStyleBackColor = true;
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 171);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PortField);
            this.Controls.Add(this.IPAddressEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Devices";
            this.Text = "Devices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPAddressEntry;
        private System.Windows.Forms.TextBox PortField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveChanges;
    }
}