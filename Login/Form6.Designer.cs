namespace Login
{
    partial class Form6
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
            this.Body = new System.Windows.Forms.RichTextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Sub = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.emailpassword = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ats = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(23, 177);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(377, 206);
            this.Body.TabIndex = 0;
            this.Body.Text = "";
            this.Body.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(75, 151);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(231, 20);
            this.Subject.TabIndex = 1;
            this.Subject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(23, 154);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(46, 13);
            this.Sub.TabIndex = 2;
            this.Sub.Text = "Subject:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.emailpassword);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 82);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailpassword
            // 
            this.emailpassword.Location = new System.Drawing.Point(85, 35);
            this.emailpassword.Name = "emailpassword";
            this.emailpassword.Size = new System.Drawing.Size(169, 20);
            this.emailpassword.TabIndex = 3;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(85, 9);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(169, 20);
            this.email.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Attachments:";
            // 
            // ats
            // 
            this.ats.Location = new System.Drawing.Point(92, 390);
            this.ats.Name = "ats";
            this.ats.ReadOnly = true;
            this.ats.Size = new System.Drawing.Size(229, 20);
            this.ats.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(325, 389);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "Add";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(325, 148);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 422);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Body);
            this.Name = "Form6";
            this.Text = "Contact Server Adminstrator";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Body;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label Sub;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox emailpassword;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ats;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button Send;
    }
}