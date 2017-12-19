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
    public partial class Form11 : MetroFramework.Forms.MetroForm
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDb)\test;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter ad;
        DataTable dt;
        public Form11()
        {
            InitializeComponent();
            
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void LoadTable()
        {
            Con.Open();
            cmd = new SqlCommand("select* from Item_General;",Con);
            ad = new SqlDataAdapter(cmd);
            ad.SelectCommand = cmd;
            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}
