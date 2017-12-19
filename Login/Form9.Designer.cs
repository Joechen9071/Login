namespace Login
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GPBX = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.User_Description = new System.Windows.Forms.RichTextBox();
            this.User_CustomizedCatergory = new System.Windows.Forms.TextBox();
            this.Catergory_Options = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserPrice = new System.Windows.Forms.TextBox();
            this.User_ItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PreviewPost = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.price = new System.Windows.Forms.Label();
            this.IName = new System.Windows.Forms.Label();
            this.PreviewPIc = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GPBX.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PreviewPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPIc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GPBX
            // 
            this.GPBX.BackColor = System.Drawing.Color.Transparent;
            this.GPBX.Controls.Add(this.pictureBox1);
            this.GPBX.Location = new System.Drawing.Point(382, 63);
            this.GPBX.Name = "GPBX";
            this.GPBX.Size = new System.Drawing.Size(183, 220);
            this.GPBX.TabIndex = 4;
            this.GPBX.TabStop = false;
            this.GPBX.Text = "Image";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.User_Description);
            this.groupBox1.Controls.Add(this.User_CustomizedCatergory);
            this.groupBox1.Controls.Add(this.Catergory_Options);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UserPrice);
            this.groupBox1.Controls.Add(this.User_ItemName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Item Description*:";
            // 
            // User_Description
            // 
            this.User_Description.Location = new System.Drawing.Point(113, 115);
            this.User_Description.Name = "User_Description";
            this.User_Description.Size = new System.Drawing.Size(240, 96);
            this.User_Description.TabIndex = 8;
            this.User_Description.Text = "";
            // 
            // User_CustomizedCatergory
            // 
            this.User_CustomizedCatergory.Location = new System.Drawing.Point(240, 89);
            this.User_CustomizedCatergory.Name = "User_CustomizedCatergory";
            this.User_CustomizedCatergory.Size = new System.Drawing.Size(113, 20);
            this.User_CustomizedCatergory.TabIndex = 7;
            this.User_CustomizedCatergory.Visible = false;
            // 
            // Catergory_Options
            // 
            this.Catergory_Options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Catergory_Options.FormattingEnabled = true;
            this.Catergory_Options.Items.AddRange(new object[] {
            "Sports",
            "Electronic",
            "Outdoor",
            "Food",
            "Book",
            "Other"});
            this.Catergory_Options.Location = new System.Drawing.Point(113, 88);
            this.Catergory_Options.Name = "Catergory_Options";
            this.Catergory_Options.Size = new System.Drawing.Size(121, 21);
            this.Catergory_Options.TabIndex = 6;
            this.Catergory_Options.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Price*:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserPrice
            // 
            this.UserPrice.Location = new System.Drawing.Point(113, 65);
            this.UserPrice.Name = "UserPrice";
            this.UserPrice.Size = new System.Drawing.Size(68, 20);
            this.UserPrice.TabIndex = 2;
            // 
            // User_ItemName
            // 
            this.User_ItemName.Location = new System.Drawing.Point(113, 36);
            this.User_ItemName.Name = "User_ItemName";
            this.User_ItemName.Size = new System.Drawing.Size(240, 20);
            this.User_ItemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name*:";
            // 
            // PreviewPost
            // 
            this.PreviewPost.Controls.Add(this.button3);
            this.PreviewPost.Controls.Add(this.description);
            this.PreviewPost.Controls.Add(this.price);
            this.PreviewPost.Controls.Add(this.IName);
            this.PreviewPost.Controls.Add(this.PreviewPIc);
            this.PreviewPost.Location = new System.Drawing.Point(17, 318);
            this.PreviewPost.Name = "PreviewPost";
            this.PreviewPost.Size = new System.Drawing.Size(543, 168);
            this.PreviewPost.TabIndex = 6;
            this.PreviewPost.TabStop = false;
            this.PreviewPost.Text = "Preview";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Publish This Post";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(175, 62);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(356, 96);
            this.description.TabIndex = 3;
            this.description.Text = "Description";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(172, 46);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 2;
            this.price.Text = "Price";
            // 
            // IName
            // 
            this.IName.AutoSize = true;
            this.IName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IName.Location = new System.Drawing.Point(172, 16);
            this.IName.Name = "IName";
            this.IName.Size = new System.Drawing.Size(89, 18);
            this.IName.TabIndex = 1;
            this.IName.Text = "Item Name";
            // 
            // PreviewPIc
            // 
            this.PreviewPIc.Location = new System.Drawing.Point(6, 19);
            this.PreviewPIc.Name = "PreviewPIc";
            this.PreviewPIc.Size = new System.Drawing.Size(160, 143);
            this.PreviewPIc.TabIndex = 0;
            this.PreviewPIc.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Preview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Note:* represents required field";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 509);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PreviewPost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GPBX);
            this.Controls.Add(this.button1);
            this.Name = "Form9";
            this.Text = "Create New Post";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GPBX.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PreviewPost.ResumeLayout(false);
            this.PreviewPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPIc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GPBX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserPrice;
        private System.Windows.Forms.TextBox User_ItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Catergory_Options;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox User_Description;
        private System.Windows.Forms.TextBox User_CustomizedCatergory;
        private System.Windows.Forms.GroupBox PreviewPost;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label IName;
        private System.Windows.Forms.PictureBox PreviewPIc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}