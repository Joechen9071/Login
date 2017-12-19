using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace Login
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        string path = "";
        string Filepath = @"C:\Users\Joe\Desktop\P.txt";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\test;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sb = new OpenFileDialog();
            DialogResult sb2 = sb.ShowDialog();
            path = sb.FileName;
            //PBX1.Image = path;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txtCommand = File.ReadAllText(Filepath);
            con.Open();
            cmd = new SqlCommand(txtCommand,con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

            }
            con.Close();

            Form1 f1 = new Form1();
            this.Hide();
            f1.FormClosed += (s, args) => this.Close();
            f1.Show();
            f1.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
