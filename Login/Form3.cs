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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDb)\test;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter ad;
        DataTable dt;

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.FormClosed += (s, args) => this.Close();
            f1.Show();
            f1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InRecord())
            {
                Form4 f4 = new Form4();
                this.Hide();
                f4.FormClosed += (s, args) => this.Close();
                f4.Show();
                f4.Focus();
            }
            else
            {
                MessageBox.Show("Admin Not Found");
            }
            

        }
        private bool InRecord()
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("select AdminName, AdminPassword from AdminRecords where AdminName = '" + AdName.Text + "' and AdminPassword='" + ADPw.Text + "';", Con);
                ad = new SqlDataAdapter(cmd);
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

            try
            {
                string temp = dt.Rows[0][0].ToString();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
