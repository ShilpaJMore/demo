namespace DBHandling
{
    partial class Form1
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
            this.txbxDBName = new System.Windows.Forms.TextBox();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnImportTable = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txbxCSVName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbxDBName
            // 
            this.txbxDBName.Location = new System.Drawing.Point(24, 25);
            this.txbxDBName.Name = "txbxDBName";
            this.txbxDBName.Size = new System.Drawing.Size(230, 20);
            this.txbxDBName.TabIndex = 0;
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDB.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreateDB.Location = new System.Drawing.Point(260, 25);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDB.TabIndex = 1;
            this.btnCreateDB.Text = "Create DB";
            this.btnCreateDB.UseVisualStyleBackColor = false;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // btnImportTable
            // 
            this.btnImportTable.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImportTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportTable.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImportTable.Location = new System.Drawing.Point(260, 65);
            this.btnImportTable.Name = "btnImportTable";
            this.btnImportTable.Size = new System.Drawing.Size(75, 23);
            this.btnImportTable.TabIndex = 2;
            this.btnImportTable.Text = "Import Table";
            this.btnImportTable.UseVisualStyleBackColor = false;
            this.btnImportTable.Click += new System.EventHandler(this.btnImportTable_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txbxCSVName
            // 
            this.txbxCSVName.Location = new System.Drawing.Point(24, 68);
            this.txbxCSVName.Name = "txbxCSVName";
            this.txbxCSVName.Size = new System.Drawing.Size(230, 20);
            this.txbxCSVName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(948, 481);
            this.Controls.Add(this.txbxCSVName);
            this.Controls.Add(this.btnImportTable);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.txbxDBName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxDBName;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnImportTable;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txbxCSVName;
    }
}

