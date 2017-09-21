using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Baza
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MedicalProgram myForm = new MedicalProgram();
            this.Hide();
            myForm.Show();
        }
    }
}
