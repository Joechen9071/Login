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
    public partial class Form9 :MetroFramework.Forms.MetroForm
    {
        string catergory = "";
        string imagelocation = "";
        string itemname = "";
        string itemprice = "";
        string itemdescription = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDb)\test;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opf = new OpenFileDialog();

            Opf.Title = "Item Image";
            if (Opf.ShowDialog() == DialogResult.OK)
            {
                imagelocation = Opf.FileName;
                pictureBox1.ImageLocation = imagelocation;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Catergory_Options.Text.Equals("Other"))
            {
                User_CustomizedCatergory.Visible = true;
            }
            else
            {
                User_CustomizedCatergory.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (User_CustomizedCatergory.Visible==true)
            {
                catergory = User_CustomizedCatergory.Text;
            }
            else
            {
                catergory = Catergory_Options.Text;
            }
            IName.Text = User_ItemName.Text;
            price.Text = UserPrice.Text;
            description.Text = User_Description.Text;
            PreviewPIc.ImageLocation = imagelocation;

            itemname = IName.Text;
            itemprice = price.Text;
            itemdescription = description.Text;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("insert into Item_General(Item_Name, Item_Price, Item_Description, Item_Category)values('" + itemname + "' , '" + itemprice + "' , '" + itemdescription + "' , '" + catergory + "');" + "insert into Item_Images(Item_Image) select Bulkcolumn from openrowset(bulk '" + imagelocation + "',Single_Blob)as img;", Con);
                dr = cmd.ExecuteReader();
                dr.Read();
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
