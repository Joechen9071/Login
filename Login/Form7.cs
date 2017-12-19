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
using System.IO;

namespace Login
{
    public partial class Form7 : MetroFramework.Forms.MetroForm
    {

        Label colname;
        Label coltype;
        ComboBox DatatypeChoices;
        TextBox coln;
        Button restart;
        Button addcol;
        Button create;
        int PosXforTBX = 40;
        int PosYforTBX = 40;
        int PosXforCBX = 210;
        int PosYforCBX = 40;
        string tablename = "";
        string temp="";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDb)\test;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        
        public Form7()
        {
            InitializeComponent();
            colname = cln;
            coltype = clt;
            DatatypeChoices = cbx;
            restart = startov;
            addcol = adc;
            create = cre;
            coln = tbx1;
            DatatypeChoices = cbx;
            panel1.Controls.Clear();

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Confirm table name ?", "Confirmation", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                Tablename.ReadOnly = true;
                panel1.Controls.Add(create);
                panel1.Controls.Add(restart);
                panel1.Controls.Add(addcol);
                panel1.Controls.Add(colname);
                panel1.Controls.Add(coltype);
                panel1.Controls.Add(coln);
                panel1.Controls.Add(DatatypeChoices);
                tablename = Tablename.Text;
            }
            else
            {

            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

        }

        private void cfm2_Click(object sender, EventArgs e)
        {
            try
            {
                

               

            }
            catch (Exception)
            { 

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("Create table " + tablename + "(" + temp + ");", Con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
                Con.Close();
                MessageBox.Show("table " + tablename + " has been successfully created");
                Form4 f4 = new Form4();
                f4.FormClosed += (s, args) => this.Close();
                this.Hide();
                f4.Show();
                f4.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void adc_Click(object sender, EventArgs e)
        {
            try
            {
                int posxfortbx = PosXforTBX;
                int posyfortbx = PosYforTBX;
                int posxforcbx = PosXforCBX;
                int posyforcbx = PosYforCBX;
                PosYforTBX = PosYforTBX + 30;
                PosYforCBX = PosYforCBX + 30;

                coln.Location = new Point(PosXforTBX, PosYforTBX);
                DatatypeChoices.Location = new Point(PosXforCBX, PosYforCBX);
                TextBox clname = new TextBox();
                clname.Text = coln.Text;
                clname.Location = new Point(posxfortbx, posyfortbx);
                clname.Size = new Size(160, 20);
                clname.ReadOnly = true;
                TextBox cldatatype = new TextBox();
                cldatatype.Text = DatatypeChoices.Text;
                cldatatype.Location = new Point(posxforcbx, posyforcbx);
                cldatatype.ReadOnly = true;
                panel1.Controls.Add(clname);
                panel1.Controls.Add(cldatatype);
                if (string.IsNullOrEmpty(temp))
                {
                    temp = temp + clname.Text + " " + cldatatype.Text;
                }
                else
                {
                    temp = temp + " ," + clname.Text + " " + cldatatype.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startov_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PosXforTBX = 40;
            PosYforCBX = 40;
            PosXforCBX = 210;
            PosYforTBX = 40;
            coln.Location = new Point(40,40);
            DatatypeChoices.Location = new Point(210,40);
            panel1.Controls.Add(coln);
            panel1.Controls.Add(DatatypeChoices);
            panel1.Controls.Add(colname);
            panel1.Controls.Add(coltype);
            panel1.Controls.Add(restart);
            panel1.Controls.Add(addcol);
            panel1.Controls.Add(create);
        }
    }
}
