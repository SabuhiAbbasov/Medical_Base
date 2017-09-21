namespace Medical_Baza
{
    partial class DeleteDepartment
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
            this.DelDepartment = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şöbəni seç";
            // 
            // DelDepartment
            // 
            this.DelDepartment.FormattingEnabled = true;
            this.DelDepartment.Location = new System.Drawing.Point(88, 13);
            this.DelDepartment.Name = "DelDepartment";
            this.DelDepartment.Size = new System.Drawing.Size(184, 21);
            this.DelDepartment.TabIndex = 1;
            this.DelDepartment.Text = "Şöbəni seç";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(196, 41);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Sil";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 74);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.DelDepartment);
            this.Controls.Add(this.label1);
            this.Name = "DeleteDepartment";
            this.Text = "DeleteDepartment";
            this.Load += new System.EventHandler(this.DeleteDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DelDepartment;
        private System.Windows.Forms.Button Delete;
    }
}