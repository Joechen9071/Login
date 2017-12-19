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

namespace Login
{
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDb)\test;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        string nameAndpassword = "";
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            nameAndpassword = "'"+UN.Text+"'"+","+"'"+PW.Text+"'";
            try
            {
                Con.Open();
                cmd = new SqlCommand("insert into UserInfo(Username,UserPassword,LoginState)values(" + nameAndpassword + ",'No');", Con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
                Con.Close();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void UN_Click(object sender, EventArgs e)
        {

        }
    }
}
