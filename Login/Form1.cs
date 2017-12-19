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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Connection String
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDb)\test;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter ad;
        SqlDataReader dr;
        List<int> UserID = new List<int>();
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(@"C:\Users\Joe\Desktop\");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.Visible = false;
            Signup.Visible = true;
            UID.ReadOnly = true;
        }
        //UserID
        private String getUID()
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("Select UID from Userinfo;", Con);
                ad = new SqlDataAdapter(cmd);
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    UserID.Add(int.Parse(dt.Rows[i][0].ToString()));
                }
                Con.Close();
                return UserID[UserID.Count - 1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "null";
            }
            finally
            {
                Con.Close();
               
            }
        }
        
      
        //Resisgter for a account
        private void Signup_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!UN.Text.Equals("")) && (!Pw.Text.Equals("")))
                {
                    Con.Open();
                    cmd = new SqlCommand("insert into UserInfo(Username, UserPassword, LoginState)values('" + UN.Text + "'" + "," + "'" + Pw.Text + "'" + "," + "'NO');", Con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                    }
                    Con.Close();

                    Con.Open();
                    cmd = new SqlCommand("insert into User_Money(Bank_Saving)values(0.00);",Con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                    }
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Username and Password Must Have Value");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (!getUID().Equals("null")) {
                int d = int.Parse(getUID());
                UID.Text = d.ToString();
            }
            else {
                UID.Text = "null";

            }
            Btl.Visible = true;
            
        }

        //update login state
        private void Login_Click(object sender, EventArgs e)
        {

            if (Inrecord())
            {
                try
                {
                    int i = int.Parse(UID.Text);
                    Con.Open();
                    cmd = new SqlCommand("update UserInfo set LoginState = 'Yes' where Username = '" + UN.Text + "' and UID=" + i + " and UserPassword ='" + Pw.Text + "';", Con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                    }
                    Con.Close();
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.FormClosed += (s, args) => this.Close();
                    f2.Show();
                    f2.Focus();
                    using (StreamWriter sw=File.CreateText(@"C:\Users\Joe\Desktop\P.txt"))
                    {
                        sw.WriteLine("update UserInfo set LoginState = 'No' where Username = '" + UN.Text + "' and UID=" + i +";");
                    }
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
            else
            {
                MessageBox.Show("Not in record");
            }
            
            
        }
        //Is entered information in record 
        private bool Inrecord()
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("select UID,Username,UserPassword,LoginState from UserInfo where UID=" + int.Parse(UID.Text) + " and Username='" + UN.Text + "' and UserPassword='" + Pw.Text + "';", Con);
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
                    Status.Text = dt.Rows[0][0].ToString();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            
            


        }
        private void Btl_Click(object sender, EventArgs e)
        {
            Signup.Visible = false;
            Login.Visible = true;
            Btl.Visible = false;
            UID.ReadOnly = false;
        }

        private void UN_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.FormClosed += (s, args) => this.Close();
            f3.Show();
            f3.Focus();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.FormClosed += (s, args) => this.Close();
            f5.Show();
            f5.Focus();
        }
    }
}
