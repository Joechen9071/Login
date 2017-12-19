using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Login
{
    public partial class Form6 : MetroFramework.Forms.MetroForm
    {
        NetworkCredential user;
        MailMessage issue;
        string attachments;
        OpenFileDialog open = new OpenFileDialog();
        public Form6()
        {
            InitializeComponent();
            Subject.ReadOnly = true;
            Body.ReadOnly = true;
            btn3.Visible = false;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = new NetworkCredential(email.Text,emailpassword.Text);
            Body.ReadOnly = false;
            Subject.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (DialogResult.OK == open.ShowDialog())
                {
                    attachments = open.FileName;
                    ats.Text = attachments;
                }
                btn3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == open.ShowDialog())
                {
                    attachments = attachments + "," + open.FileName;
                    ats.Text = attachments;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient server = new SmtpClient("smtp.gmail.com");
                MailMessage mail = new MailMessage(email.Text, "bhstianyu@Gmail.com");
                server.UseDefaultCredentials = false;
                server.Credentials = user;
                server.Port = 587;
                server.EnableSsl = true;
                if (ats.Text.Length>1) {
                    string[] attachedments = ats.Text.Split(',');
                    foreach (string i in attachedments)
                    {
                        mail.Attachments.Add(new Attachment(i));
                    } }
            
                mail.Subject = Subject.Text;
                mail.Body = Body.Text;
                server.Send(mail);
                MessageBox.Show("Mail Sent !","Success ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Send Email", "Failed To send Email");
            }
        }
    }
}
