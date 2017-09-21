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
            this.DoctorClick = new System.Windows.Forms.Button();
            this.Nurse_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Departament
            // 
            this.Departament.Location = new System.Drawing.Point(13, 13);
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(114, 25);
            this.Departament.TabIndex = 0;
            this.Departament.Text = "Departament";
            this.Departament.UseVisualStyleBackColor = true;
            this.Departament.Click += new System.EventHandler(this.Departament_Click);
            // 
            // DoctorClick
            // 
            this.DoctorClick.Location = new System.Drawing.Point(134, 13);
            this.DoctorClick.Name = "DoctorClick";
            this.DoctorClick.Size = new System.Drawing.Size(114, 25);
            this.DoctorClick.TabIndex = 1;
            this.DoctorClick.Text = "Doctor";
            this.DoctorClick.UseVisualStyleBackColor = true;
            this.DoctorClick.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // Nurse_Click
            // 
            this.Nurse_Click.Location = new System.Drawing.Point(255, 13);
            this.Nurse_Click.Name = "Nurse_Click";
            this.Nurse_Click.Size = new System.Drawing.Size(114, 25);
            this.Nurse_Click.TabIndex = 2;
            this.Nurse_Click.Text = "Nurse";
            this.Nurse_Click.UseVisualStyleBackColor = true;
            this.Nurse_Click.Click += new System.EventHandler(this.Nurse_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(150, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qeydiyyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(231, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yas";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 106);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(231, 105);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "+994";
            // 
            // MedicalProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nurse_Click);
            this.Controls.Add(this.DoctorClick);
            this.Controls.Add(this.Departament);
            this.Name = "MedicalProgram";
            this.Text = "MedicalProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Departament;
        private System.Windows.Forms.Button DoctorClick;
        private System.Windows.Forms.Button Nurse_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
    }
}