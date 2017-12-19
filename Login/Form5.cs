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
using System.Net;
using System.Net.Mail;

namespace Login
{
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\test;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter ad;
        SqlCommand cmd;
        DataTable dt;
        string password;

        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Inrecord())
            {
                MailMessage msg = new MailMessage("Bhstianyu@gmail.com",Email.Text,"Account Recovery","Dear "+Un.Text+"\n Here's Your Account Information: \n"+"Username:"+Un.Text+"\n UID:"+UID.Text+"\n Password:"+password+"\n \n Thanks For Using our Products");
                SmtpClient sm = new SmtpClient("smtp.gmail.com",587);
                NetworkCredential nc = new NetworkCredential("bhstianyu@gmail.com","tianyu123");
                sm.UseDefaultCredentials = false;
                sm.Credentials = nc;
                sm.EnableSsl = true;
                sm.Send(msg);
                MessageBox.Show("Email has been send to your email");
            }
            else
            {
                MessageBox.Show("Enter Correct Information");
            }
        }
        private bool Inrecord()
        {
            con.Open();
            cmd = new SqlCommand("select UserPassword from UserInfo WHERE Username = '"+Un.Text+"' and UID=" +int.Parse(UID.Text)+";" ,con);
            ad = new SqlDataAdapter(cmd);
            ad.SelectCommand = cmd;
            dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            try{
                password = dt.Rows[0][0].ToString();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
