namespace Medical_Baza
{
    partial class UserPassword
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
            this.User_name = new System.Windows.Forms.TextBox();
            this.Pass_word = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pr = new System.Windows.Forms.Label();
            this.ClickProg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // User_name
            // 
            this.User_name.Location = new System.Drawing.Point(125, 40);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(164, 20);
            this.User_name.TabIndex = 1;
            // 
            // Pass_word
            // 
            this.Pass_word.Location = new System.Drawing.Point(125, 67);
            this.Pass_word.Name = "Pass_word";
            this.Pass_word.PasswordChar = '*';
            this.Pass_word.Size = new System.Drawing.Size(164, 20);
            this.Pass_word.TabIndex = 2;
            this.Pass_word.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(86, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Istifadeci adi ve ya parol sefdir";
            this.label3.Visible = false;
            // 
            // Pr
            // 
            this.Pr.AutoSize = true;
            this.Pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Pr.Location = new System.Drawing.Point(107, 14);
            this.Pr.Name = "Pr";
            this.Pr.Size = new System.Drawing.Size(108, 17);
            this.Pr.TabIndex = 5;
            this.Pr.Text = "Programa girish";
            // 
            // ClickProg
            // 
            this.ClickProg.Location = new System.Drawing.Point(149, 93);
            this.ClickProg.Name = "ClickProg";
            this.ClickProg.Size = new System.Drawing.Size(75, 23);
            this.ClickProg.TabIndex = 6;
            this.ClickProg.Text = "Girish";
            this.ClickProg.UseVisualStyleBackColor = true;
            this.ClickProg.Click += new System.EventHandler(this.ClickProg_Click);
            // 
            // UserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 150);
            this.Controls.Add(this.ClickProg);
            this.Controls.Add(this.Pr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pass_word);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.label1);
            this.Name = "UserPassword";
            this.Text = "User&Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.TextBox Pass_word;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Pr;
        private System.Windows.Forms.Button ClickProg;
    }
}

