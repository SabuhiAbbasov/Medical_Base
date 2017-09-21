using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medical_Baza
{
    public partial class Department_Form : Form
    {
        public Department_Form()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MedicalProgram myForm = new MedicalProgram();
            this.Hide();
            myForm.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddDepartment myForm = new AddDepartment();
            myForm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteDepartment myForm = new DeleteDepartment();
            myForm.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditDepartment myForm = new EditDepartment();
            myForm.Show();
        }
    }
}
