namespace NotebookSQLiteApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearchModel;
        private System.Windows.Forms.TextBox txtSearchReverseNo;
        private System.Windows.Forms.TextBox txtSearchDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnBackupDB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSearchModel = new System.Windows.Forms.TextBox();
            txtSearchReverseNo = new System.Windows.Forms.TextBox();
            txtSearchDescription = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            lblRowCount = new System.Windows.Forms.Label();
            btnExportExcel = new System.Windows.Forms.Button();
            btnImportExcel = new System.Windows.Forms.Button();
            btnClearAll = new System.Windows.Forms.Button();
            btnBackupDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearchModel
            // 
            txtSearchModel.Location = new System.Drawing.Point(20, 20);
            txtSearchModel.Name = "txtSearchModel";
            txtSearchModel.PlaceholderText = "Search Model";
            txtSearchModel.Size = new System.Drawing.Size(150, 23);
            txtSearchModel.TabIndex = 0;
            // 
            // txtSearchReverseNo
            // 
            txtSearchReverseNo.Location = new System.Drawing.Point(180, 20);
            txtSearchReverseNo.Name = "txtSearchReverseNo";
            txtSearchReverseNo.PlaceholderText = "Search ReverseNo";
            txtSearchReverseNo.Size = new System.Drawing.Size(150, 23);
            txtSearchReverseNo.TabIndex = 1;
            // 
            // txtSearchDescription
            // 
            txtSearchDescription.Location = new System.Drawing.Point(340, 20);
            txtSearchDescription.Name = "txtSearchDescription";
            txtSearchDescription.PlaceholderText = "Search Description";
            txtSearchDescription.Size = new System.Drawing.Size(150, 23);
            txtSearchDescription.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new System.Drawing.Point(20, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(700, 400);
            dataGridView1.TabIndex = 3;
            // 
            // lblRowCount
            // 
            lblRowCount.Location = new System.Drawing.Point(20, 470);
            lblRowCount.Name = "lblRowCount";
            lblRowCount.Size = new System.Drawing.Size(300, 23);
            lblRowCount.TabIndex = 4;
            lblRowCount.Text = "Total Rows: 0";
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new System.Drawing.Point(400, 470);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new System.Drawing.Size(75, 30);
            btnExportExcel.TabIndex = 5;
            btnExportExcel.Text = "Export";
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnImportExcel
            // 
            btnImportExcel.Location = new System.Drawing.Point(480, 470);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new System.Drawing.Size(75, 30);
            btnImportExcel.TabIndex = 6;
            btnImportExcel.Text = "Import";
            btnImportExcel.Click += btnImportExcel_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new System.Drawing.Point(560, 470);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new System.Drawing.Size(75, 30);
            btnClearAll.TabIndex = 7;
            btnClearAll.Text = "Clear All";
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnBackupDB
            // 
            btnBackupDB.Location = new System.Drawing.Point(640, 470);
            btnBackupDB.Name = "btnBackupDB";
            btnBackupDB.Size = new System.Drawing.Size(80, 30);
            btnBackupDB.TabIndex = 8;
            btnBackupDB.Text = "Backup";
            btnBackupDB.Click += btnBackupDB_Click;
            // 
            // Form2
            // 
            ClientSize = new System.Drawing.Size(750, 520);
            Controls.Add(txtSearchModel);
            Controls.Add(txtSearchReverseNo);
            Controls.Add(txtSearchDescription);
            Controls.Add(dataGridView1);
            Controls.Add(lblRowCount);
            Controls.Add(btnExportExcel);
            Controls.Add(btnImportExcel);
            Controls.Add(btnClearAll);
            Controls.Add(btnBackupDB);
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Data Viewer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
