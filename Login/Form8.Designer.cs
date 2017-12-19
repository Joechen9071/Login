namespace Login
{
    partial class Form8
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.UN = new MetroFramework.Controls.MetroTextBox();
            this.PW = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(159, 207);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Insert";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // UN
            // 
            // 
            // 
            // 
            this.UN.CustomButton.Image = null;
            this.UN.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.UN.CustomButton.Name = "";
            this.UN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UN.CustomButton.TabIndex = 1;
            this.UN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UN.CustomButton.UseSelectable = true;
            this.UN.CustomButton.Visible = false;
            this.UN.Lines = new string[0];
            this.UN.Location = new System.Drawing.Point(127, 119);
            this.UN.MaxLength = 32767;
            this.UN.Name = "UN";
            this.UN.PasswordChar = '\0';
            this.UN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UN.SelectedText = "";
            this.UN.SelectionLength = 0;
            this.UN.SelectionStart = 0;
            this.UN.ShortcutsEnabled = true;
            this.UN.Size = new System.Drawing.Size(152, 23);
            this.UN.TabIndex = 2;
            this.UN.UseSelectable = true;
            this.UN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.UN.Click += new System.EventHandler(this.UN_Click);
            // 
            // PW
            // 
            // 
            // 
            // 
            this.PW.CustomButton.Image = null;
            this.PW.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.PW.CustomButton.Name = "";
            this.PW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PW.CustomButton.TabIndex = 1;
            this.PW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PW.CustomButton.UseSelectable = true;
            this.PW.CustomButton.Visible = false;
            this.PW.Lines = new string[0];
            this.PW.Location = new System.Drawing.Point(127, 148);
            this.PW.MaxLength = 32767;
            this.PW.Name = "PW";
            this.PW.PasswordChar = '\0';
            this.PW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PW.SelectedText = "";
            this.PW.SelectionLength = 0;
            this.PW.SelectionStart = 0;
            this.PW.ShortcutsEnabled = true;
            this.PW.Size = new System.Drawing.Size(152, 23);
            this.PW.TabIndex = 3;
            this.PW.UseSelectable = true;
            this.PW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Password:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 359);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.UN);
            this.Controls.Add(this.metroButton2);
            this.Name = "Form8";
            this.ShowIcon = false;
            this.Text = "Manual Insert";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox UN;
        private MetroFramework.Controls.MetroTextBox PW;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}