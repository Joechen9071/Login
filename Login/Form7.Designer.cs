namespace Login
{
    partial class Form7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.startov = new System.Windows.Forms.Button();
            this.adc = new System.Windows.Forms.Button();
            this.cre = new System.Windows.Forms.Button();
            this.clt = new System.Windows.Forms.Label();
            this.cln = new System.Windows.Forms.Label();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tablename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startov);
            this.panel1.Controls.Add(this.adc);
            this.panel1.Controls.Add(this.cre);
            this.panel1.Controls.Add(this.clt);
            this.panel1.Controls.Add(this.cln);
            this.panel1.Controls.Add(this.cbx);
            this.panel1.Controls.Add(this.tbx1);
            this.panel1.Location = new System.Drawing.Point(23, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 366);
            this.panel1.TabIndex = 0;
            // 
            // startov
            // 
            this.startov.Location = new System.Drawing.Point(338, 130);
            this.startov.Name = "startov";
            this.startov.Size = new System.Drawing.Size(86, 23);
            this.startov.TabIndex = 12;
            this.startov.Text = "Start Over";
            this.startov.UseVisualStyleBackColor = true;
            this.startov.Click += new System.EventHandler(this.startov_Click);
            // 
            // adc
            // 
            this.adc.Location = new System.Drawing.Point(338, 71);
            this.adc.Name = "adc";
            this.adc.Size = new System.Drawing.Size(86, 23);
            this.adc.TabIndex = 11;
            this.adc.Text = "Add Column";
            this.adc.UseVisualStyleBackColor = true;
            this.adc.Click += new System.EventHandler(this.adc_Click);
            // 
            // cre
            // 
            this.cre.Location = new System.Drawing.Point(351, 100);
            this.cre.Name = "cre";
            this.cre.Size = new System.Drawing.Size(73, 24);
            this.cre.TabIndex = 10;
            this.cre.Text = "Create";
            this.cre.UseVisualStyleBackColor = true;
            this.cre.Click += new System.EventHandler(this.button2_Click);
            // 
            // clt
            // 
            this.clt.AutoSize = true;
            this.clt.Location = new System.Drawing.Point(206, 25);
            this.clt.Name = "clt";
            this.clt.Size = new System.Drawing.Size(72, 13);
            this.clt.TabIndex = 4;
            this.clt.Text = "Column Type:";
            // 
            // cln
            // 
            this.cln.AutoSize = true;
            this.cln.Location = new System.Drawing.Point(40, 25);
            this.cln.Name = "cln";
            this.cln.Size = new System.Drawing.Size(76, 13);
            this.cln.TabIndex = 3;
            this.cln.Text = "Column Name:";
            // 
            // cbx
            // 
            this.cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx.FormattingEnabled = true;
            this.cbx.Items.AddRange(new object[] {
            "nvarchar(50)",
            "int"});
            this.cbx.Location = new System.Drawing.Point(210, 40);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(108, 21);
            this.cbx.TabIndex = 2;
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(40, 40);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(162, 20);
            this.tbx1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tablename
            // 
            this.Tablename.Location = new System.Drawing.Point(119, 60);
            this.Tablename.Name = "Tablename";
            this.Tablename.Size = new System.Drawing.Size(166, 20);
            this.Tablename.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tablename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.Text = "Create Table";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tablename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label clt;
        private System.Windows.Forms.Label cln;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.Button cre;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.Button adc;
        private System.Windows.Forms.Button startov;
    }
}