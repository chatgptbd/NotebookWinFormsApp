namespace NotebookWinFormsApp
{
    partial class IncomeEntryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbShopName;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Button btnAutoDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblMonthlyAmount;
        private System.Windows.Forms.Label lblYearAmount;
        private System.Windows.Forms.Label labelMonthlyText;
        private System.Windows.Forms.Label labelYearlyText;

        private void InitializeComponent()
        {
            cmbShopName = new System.Windows.Forms.ComboBox();
            dtpMonth = new System.Windows.Forms.DateTimePicker();
            lblOwner = new System.Windows.Forms.Label();
            lblMobile = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            dgvIncome = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAutoDate = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnLoadData = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            lblMonthlyAmount = new System.Windows.Forms.Label();
            lblYearAmount = new System.Windows.Forms.Label();
            labelMonthlyText = new System.Windows.Forms.Label();
            labelYearlyText = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIncome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // cmbShopName
            // 
            cmbShopName.Location = new System.Drawing.Point(30, 20);
            cmbShopName.Name = "cmbShopName";
            cmbShopName.Size = new System.Drawing.Size(250, 23);
            cmbShopName.TabIndex = 0;
            cmbShopName.TextChanged += cmbShopName_TextChanged;
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = "MM/yyyy";
            dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpMonth.Location = new System.Drawing.Point(522, 22);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.ShowUpDown = true;
            dtpMonth.Size = new System.Drawing.Size(100, 23);
            dtpMonth.TabIndex = 1;
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Location = new System.Drawing.Point(30, 50);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new System.Drawing.Size(42, 15);
            lblOwner.TabIndex = 2;
            lblOwner.Text = "Owner";
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Location = new System.Drawing.Point(30, 70);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new System.Drawing.Size(44, 15);
            lblMobile.TabIndex = 3;
            lblMobile.Text = "Mobile";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(30, 90);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(49, 15);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // dgvIncome
            // 
            dgvIncome.AllowUserToAddRows = false;
            dgvIncome.AllowUserToDeleteRows = false;
            dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvIncome.Location = new System.Drawing.Point(12, 138);
            dgvIncome.Name = "dgvIncome";
            dgvIncome.ReadOnly = true;
            dgvIncome.Size = new System.Drawing.Size(267, 442);
            dgvIncome.TabIndex = 2;
            dgvIncome.KeyDown += dgvIncome_KeyDown;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Date";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Income";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnAutoDate
            // 
            btnAutoDate.Location = new System.Drawing.Point(642, 22);
            btnAutoDate.Name = "btnAutoDate";
            btnAutoDate.Size = new System.Drawing.Size(100, 30);
            btnAutoDate.TabIndex = 5;
            btnAutoDate.Text = "Auto Date";
            btnAutoDate.Click += btnAutoDate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(672, 82);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(100, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.Click += btnSaveIncome_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new System.Drawing.Point(672, 122);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new System.Drawing.Size(100, 30);
            btnLoadData.TabIndex = 7;
            btnLoadData.Text = "Load";
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(672, 162);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(100, 30);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit Mode";
            btnEdit.Click += btnEdit_Click;
            // 
            // lblMonthlyAmount
            // 
            lblMonthlyAmount.BackColor = System.Drawing.Color.Cornsilk;
            lblMonthlyAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblMonthlyAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblMonthlyAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMonthlyAmount.Location = new System.Drawing.Point(782, 222);
            lblMonthlyAmount.Name = "lblMonthlyAmount";
            lblMonthlyAmount.Size = new System.Drawing.Size(100, 23);
            lblMonthlyAmount.TabIndex = 10;
            lblMonthlyAmount.Text = "0.00";
            lblMonthlyAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblYearAmount
            // 
            lblYearAmount.BackColor = System.Drawing.Color.Cornsilk;
            lblYearAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblYearAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblYearAmount.Location = new System.Drawing.Point(782, 252);
            lblYearAmount.Name = "lblYearAmount";
            lblYearAmount.Size = new System.Drawing.Size(100, 23);
            lblYearAmount.TabIndex = 12;
            lblYearAmount.Text = "0.00";
            lblYearAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMonthlyText
            // 
            labelMonthlyText.Location = new System.Drawing.Point(672, 222);
            labelMonthlyText.Name = "labelMonthlyText";
            labelMonthlyText.Size = new System.Drawing.Size(100, 15);
            labelMonthlyText.TabIndex = 9;
            labelMonthlyText.Text = "Monthly Amount:";
            // 
            // labelYearlyText
            // 
            labelYearlyText.Location = new System.Drawing.Point(672, 252);
            labelYearlyText.Name = "labelYearlyText";
            labelYearlyText.Size = new System.Drawing.Size(100, 15);
            labelYearlyText.TabIndex = 11;
            labelYearlyText.Text = "Yearly Amount:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(285, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(240, 247);
            dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(285, 418);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(240, 162);
            dataGridView2.TabIndex = 14;
            // 
            // IncomeEntryForm
            // 
            ClientSize = new System.Drawing.Size(984, 611);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(cmbShopName);
            Controls.Add(dtpMonth);
            Controls.Add(lblOwner);
            Controls.Add(lblMobile);
            Controls.Add(lblAddress);
            Controls.Add(dgvIncome);
            Controls.Add(btnAutoDate);
            Controls.Add(btnSave);
            Controls.Add(btnLoadData);
            Controls.Add(btnEdit);
            Controls.Add(labelMonthlyText);
            Controls.Add(lblMonthlyAmount);
            Controls.Add(labelYearlyText);
            Controls.Add(lblYearAmount);
            Name = "IncomeEntryForm";
            Text = "Income Entry Form";
            ((System.ComponentModel.ISupportInitialize)dgvIncome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
