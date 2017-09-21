namespace Medical_Baza
{
    partial class Doctor
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
            this.DoctorAdd = new System.Windows.Forms.Button();
            this.DoctorDel = new System.Windows.Forms.Button();
            this.DoctorEdit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoctorAdd
            // 
            this.DoctorAdd.Location = new System.Drawing.Point(50, 12);
            this.DoctorAdd.Name = "DoctorAdd";
            this.DoctorAdd.Size = new System.Drawing.Size(118, 47);
            this.DoctorAdd.TabIndex = 0;
            this.DoctorAdd.Text = "Add";
            this.DoctorAdd.UseVisualStyleBackColor = true;
            // 
            // DoctorDel
            // 
            this.DoctorDel.Location = new System.Drawing.Point(50, 65);
            this.DoctorDel.Name = "DoctorDel";
            this.DoctorDel.Size = new System.Drawing.Size(118, 47);
            this.DoctorDel.TabIndex = 1;
            this.DoctorDel.Text = "Delete";
            this.DoctorDel.UseVisualStyleBackColor = true;
            // 
            // DoctorEdit
            // 
            this.DoctorEdit.Location = new System.Drawing.Point(50, 118);
            this.DoctorEdit.Name = "DoctorEdit";
            this.DoctorEdit.Size = new System.Drawing.Size(118, 47);
            this.DoctorEdit.TabIndex = 2;
            this.DoctorEdit.Text = "Edit";
            this.DoctorEdit.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 173);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 25);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 210);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DoctorEdit);
            this.Controls.Add(this.DoctorDel);
            this.Controls.Add(this.DoctorAdd);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoctorAdd;
        private System.Windows.Forms.Button DoctorDel;
        private System.Windows.Forms.Button DoctorEdit;
        private System.Windows.Forms.Button Back;
    }
}