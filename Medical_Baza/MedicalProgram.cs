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
    public partial class MedicalProgram : Form
    {
        public MedicalProgram()
        {
            InitializeComponent();
        }

        private void Departament_Click(object sender, EventArgs e)
        {
            Department_Form myForm = new Department_Form();
            this.Hide();
            myForm.Show();
        }
    }
}
