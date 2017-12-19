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
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDb)\test;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter ad;
        SqlDataReader dr;
        DataTable dt;
        string filename;
        public Form4()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("Select * from UserInfo", Con);
                ad = new SqlDataAdapter(cmd);
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private bool Inrecord()
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("select * from UserInfo where UID=" + int.Parse(UID.Text) + " and Username ='" + UN.Text + "';", Con);
                ad = new SqlDataAdapter(cmd);
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.AutoResizeColumns();
                Con.Close();
                try
                {
                    string temp = dt.Rows[0][0].ToString();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                Con.Close();
            }
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Inrecord())
            {
                Con.Open();
                cmd = new SqlCommand("select * from UserInfo where UID=" + int.Parse(UID.Text) + " and Username ='" + UN.Text + "';", Con);
                ad = new SqlDataAdapter(cmd);
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                Con.Close();
            }
            else
            {
                MessageBox.Show("Not In record");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void importCsvFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file2 = new OpenFileDialog();
            DialogResult ds = file2.ShowDialog();
            filename = file2.FileName;
            Des.Text = filename;
            try
            {
                Con.Open();
                cmd = new SqlCommand("bulk insert userinfo from '" + filename + "' with (fieldterminator=',', rowterminator='\n');", Con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
                Con.Close();
                MessageBox.Show(filename +" has successfully imported into table ");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void clearUserRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("truncate table userinfo", Con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
                Con.Close();
                MessageBox.Show("User Table Cleared");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void contactAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            f6.Focus();
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            f7.Focus();
        }

        private void allTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("select name from sys.tables", Con);
                ad = new SqlDataAdapter(cmd);
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
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
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }
    }
}
