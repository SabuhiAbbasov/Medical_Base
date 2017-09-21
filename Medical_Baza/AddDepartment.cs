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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var conString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Medical;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(conString);

            conn.Open();

            var UserName = Name.Text;
            var UserLocation = Location.Text;
            var UserDescription = Description.Text;

            var addsql = "Insert into [dbo].[Departament](Name,Description)Values('"+UserName+"','"+UserDescription+"')";
            SqlCommand cmd = new SqlCommand(addsql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
