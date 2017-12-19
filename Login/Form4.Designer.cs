namespace Login
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayUserRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCsvFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearUserRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UN = new System.Windows.Forms.TextBox();
            this.UID = new System.Windows.Forms.TextBox();
            this.Des = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayUserRecordToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.contactAdminToolStripMenuItem,
            this.createTableToolStripMenuItem,
            this.allTablesToolStripMenuItem,
            this.saleListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayUserRecordToolStripMenuItem
            // 
            this.displayUserRecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRecordToolStripMenuItem});
            this.displayUserRecordToolStripMenuItem.Name = "displayUserRecordToolStripMenuItem";
            this.displayUserRecordToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.displayUserRecordToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.displayUserRecordToolStripMenuItem.Text = "Display  ";
            // 
            // userRecordToolStripMenuItem
            // 
            this.userRecordToolStripMenuItem.Name = "userRecordToolStripMenuItem";
            this.userRecordToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.userRecordToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.userRecordToolStripMenuItem.Text = "User Record / Refresh ";
            this.userRecordToolStripMenuItem.Click += new System.EventHandler(this.userRecordToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.searchToolStripMenuItem.Text = "Search F1";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCsvFileToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // importCsvFileToolStripMenuItem
            // 
            this.importCsvFileToolStripMenuItem.Name = "importCsvFileToolStripMenuItem";
            this.importCsvFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.importCsvFileToolStripMenuItem.Text = "Import Csv File";
            this.importCsvFileToolStripMenuItem.Click += new System.EventHandler(this.importCsvFileToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearUserRecordToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // clearUserRecordToolStripMenuItem
            // 
            this.clearUserRecordToolStripMenuItem.Name = "clearUserRecordToolStripMenuItem";
            this.clearUserRecordToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.clearUserRecordToolStripMenuItem.Text = "Clear User Record";
            this.clearUserRecordToolStripMenuItem.Click += new System.EventHandler(this.clearUserRecordToolStripMenuItem_Click);
            // 
            // contactAdminToolStripMenuItem
            // 
            this.contactAdminToolStripMenuItem.Name = "contactAdminToolStripMenuItem";
            this.contactAdminToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.contactAdminToolStripMenuItem.Text = "Contact Admin";
            this.contactAdminToolStripMenuItem.Click += new System.EventHandler(this.contactAdminToolStripMenuItem_Click);
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.createTableToolStripMenuItem.Text = "Create Table";
            this.createTableToolStripMenuItem.Click += new System.EventHandler(this.createTableToolStripMenuItem_Click);
            // 
            // allTablesToolStripMenuItem
            // 
            this.allTablesToolStripMenuItem.Name = "allTablesToolStripMenuItem";
            this.allTablesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.allTablesToolStripMenuItem.Text = "All Tables";
            this.allTablesToolStripMenuItem.Click += new System.EventHandler(this.allTablesToolStripMenuItem_Click);
            // 
            // saleListToolStripMenuItem
            // 
            this.saleListToolStripMenuItem.Name = "saleListToolStripMenuItem";
            this.saleListToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.saleListToolStripMenuItem.Text = "SaleList";
            this.saleListToolStripMenuItem.Click += new System.EventHandler(this.saleListToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(530, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 475);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UN
            // 
            this.UN.BackColor = System.Drawing.Color.White;
            this.UN.Location = new System.Drawing.Point(80, 34);
            this.UN.Name = "UN";
            this.UN.Size = new System.Drawing.Size(100, 20);
            this.UN.TabIndex = 5;
            // 
            // UID
            // 
            this.UID.Location = new System.Drawing.Point(80, 60);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(100, 20);
            this.UID.TabIndex = 6;
            // 
            // Des
            // 
            this.Des.Location = new System.Drawing.Point(608, 37);
            this.Des.Name = "Des";
            this.Des.ReadOnly = true;
            this.Des.Size = new System.Drawing.Size(362, 20);
            this.Des.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(524, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Destination:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UID);
            this.groupBox1.Controls.Add(this.UN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 104);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Des);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Admin Navigation ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayUserRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRecordToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UN;
        private System.Windows.Forms.TextBox UID;
        private System.Windows.Forms.TextBox Des;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCsvFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearUserRecordToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem contactAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem allTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleListToolStripMenuItem;
    }
}