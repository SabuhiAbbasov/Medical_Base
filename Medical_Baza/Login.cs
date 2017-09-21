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
    public partial class UserPassword : Form
    {
        public UserPassword()
        {
            InitializeComponent();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClickProg_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Medical;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);

            conn.Open();

            var selectSql = "Select * from [dbo].[User]";
            var selectCmd = new SqlCommand(selectSql, conn);

            var adaptr = new SqlDataAdapter(selectCmd);
            var ds = new DataSet();
            adaptr.Fill(ds);

            var userText = User_name.Text;
            var textPass = Pass_word.Text;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToString(ds.Tables[0].Rows[i]["Password"]) == textPass && Convert.ToString(ds.Tables[0].Rows[i]["UserName"]) == userText)
                {
                    MedicalProgram myForm = new MedicalProgram();
                    this.Hide();
                    myForm.Show();

                }
                else
                {
                    //label3.Visible = true;
                    //MessageBox.Show("Istifadeci adi ve ya parol sefdir");
                    //MessageBox.Show(Convert.ToString(ds.Tables[0].Rows[i]["Password"]));

                    MedicalProgram myForm = new MedicalProgram();
                    this.Hide();
                    myForm.Show();

                }

            }

        }
    }
}
