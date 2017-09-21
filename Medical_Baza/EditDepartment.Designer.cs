namespace Medical_Baza
{
    partial class EditDepartment
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
            this.EditDep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şöbə seç";
            // 
            // EditDep
            // 
            this.EditDep.FormattingEnabled = true;
            this.EditDep.Location = new System.Drawing.Point(103, 13);
            this.EditDep.Name = "EditDep";
            this.EditDep.Size = new System.Drawing.Size(169, 21);
            this.EditDep.TabIndex = 1;
            this.EditDep.Text = "Şöbə seç";
            this.EditDep.SelectedIndexChanged += new System.EventHandler(this.EditDep_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şöbənin adı";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(103, 46);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(169, 20);
            this.Name.TabIndex = 2;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(197, 73);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.EditDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Text = "EditDepartment";
            this.Load += new System.EventHandler(this.EditDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EditDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button Edit;
    }
}