namespace Medical_Baza
{
    partial class MedicalProgram
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
            this.Departament = new System.Windows.Forms.Button();
            this.Doctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Departament
            // 
            this.Departament.Location = new System.Drawing.Point(13, 13);
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(114, 41);
            this.Departament.TabIndex = 0;
            this.Departament.Text = "Departament";
            this.Departament.UseVisualStyleBackColor = true;
            this.Departament.Click += new System.EventHandler(this.Departament_Click);
            // 
            // Doctor
            // 
            this.Doctor.Location = new System.Drawing.Point(134, 13);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(114, 41);
            this.Doctor.TabIndex = 1;
            this.Doctor.Text = "Doctor";
            this.Doctor.UseVisualStyleBackColor = true;
            // 
            // MedicalProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.Departament);
            this.Name = "MedicalProgram";
            this.Text = "MedicalProgram";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Departament;
        private System.Windows.Forms.Button Doctor;
    }
}