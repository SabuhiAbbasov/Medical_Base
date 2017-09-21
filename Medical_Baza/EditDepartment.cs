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
    public partial class EditDepartment : Form
    {
        public EditDepartment()
        {
            InitializeComponent();
        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {
            var conString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Medical;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(conString);

            conn.Open();
            var selectSql = "Select * from [dbo].[Departament]";
            var selectCmd = new SqlCommand(selectSql, conn);

            var adaptr = new SqlDataAdapter(selectCmd);
            var ds = new DataSet();
            adaptr.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                EditDep.Items.Add(ds.Tables[0].Rows[i]["Name"].ToString());
            }
        }

        private void EditDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (EditDep)
            //{
                var connString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection conn = new SqlConnection(connString);

                var selectsql = "Select * from [dbo].[Department]";
                var selectCmd = new SqlCommand(selectsql, conn);

                conn.Open();

                var adaptr = new SqlDataAdapter(selectCmd);
                var ds = new DataSet();
                adaptr.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Name.Text = Convert.ToString(ds.Tables[0].Rows[i]["Name"]);
                }

            //}

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            var texName = Name.Text;

            var selectsql = "UPDATE [dbo].[Department] SET Name = '" + texName + "' Where name = '" + EditDep.Text + "'";
            var selectCmd = new SqlCommand(selectsql, conn);
            selectCmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
