namespace NotebookWinFormsApp
{
    partial class EmployeeListForm
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ColSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColEmpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColJointDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColInitialSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColMaritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtSearchName = new System.Windows.Forms.TextBox();
            txtSearchMobileNo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            picPhoto = new System.Windows.Forms.PictureBox();
            txtPresentAddress = new System.Windows.Forms.TextBox();
            txtPermanentAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColSerial, ColEmpCode, ColName, ColMobileNo, ColJointDate, ColInitialSalary, ColMaritalStatus, ColGender });
            dataGridView1.Location = new System.Drawing.Point(17, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(854, 399);
            dataGridView1.TabIndex = 3;
            // 
            // ColSerial
            // 
            ColSerial.DataPropertyName = "Serial";
            ColSerial.HeaderText = "Serial";
            ColSerial.Name = "ColSerial";
            ColSerial.ReadOnly = true;
            // 
            // ColEmpCode
            // 
            ColEmpCode.DataPropertyName = "EmpCode";
            ColEmpCode.HeaderText = "EmpCode";
            ColEmpCode.Name = "ColEmpCode";
            ColEmpCode.ReadOnly = true;
            // 
            // ColName
            // 
            ColName.DataPropertyName = "Name";
            ColName.HeaderText = "Name";
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // ColMobileNo
            // 
            ColMobileNo.DataPropertyName = "MobileNo";
            ColMobileNo.HeaderText = "Mobile No";
            ColMobileNo.Name = "ColMobileNo";
            ColMobileNo.ReadOnly = true;
            // 
            // ColJointDate
            // 
            ColJointDate.DataPropertyName = "JointDate";
            ColJointDate.HeaderText = "JointDate";
            ColJointDate.Name = "ColJointDate";
            ColJointDate.ReadOnly = true;
            // 
            // ColInitialSalary
            // 
            ColInitialSalary.DataPropertyName = "Salary";
            ColInitialSalary.HeaderText = "Salary";
            ColInitialSalary.Name = "ColInitialSalary";
            ColInitialSalary.ReadOnly = true;
            // 
            // ColMaritalStatus
            // 
            ColMaritalStatus.DataPropertyName = "Marital";
            ColMaritalStatus.HeaderText = "Marital";
            ColMaritalStatus.Name = "ColMaritalStatus";
            ColMaritalStatus.ReadOnly = true;
            // 
            // ColGender
            // 
            ColGender.DataPropertyName = "Gender";
            ColGender.HeaderText = "Gender";
            ColGender.Name = "ColGender";
            ColGender.ReadOnly = true;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new System.Drawing.Point(98, 12);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new System.Drawing.Size(167, 23);
            txtSearchName.TabIndex = 0;
            // 
            // txtSearchMobileNo
            // 
            txtSearchMobileNo.Location = new System.Drawing.Point(405, 13);
            txtSearchMobileNo.Name = "txtSearchMobileNo";
            txtSearchMobileNo.Size = new System.Drawing.Size(177, 23);
            txtSearchMobileNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 15);
            label1.TabIndex = 8;
            label1.Text = "Search Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(290, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 15);
            label2.TabIndex = 9;
            label2.Text = "Search Mobile No";
            // 
            // picPhoto
            // 
            picPhoto.Location = new System.Drawing.Point(891, 56);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new System.Drawing.Size(122, 74);
            picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPhoto.TabIndex = 10;
            picPhoto.TabStop = false;
            // 
            // txtPresentAddress
            // 
            txtPresentAddress.Location = new System.Drawing.Point(891, 183);
            txtPresentAddress.Multiline = true;
            txtPresentAddress.Name = "txtPresentAddress";
            txtPresentAddress.ReadOnly = true;
            txtPresentAddress.Size = new System.Drawing.Size(132, 49);
            txtPresentAddress.TabIndex = 11;
            // 
            // txtPermanentAddress
            // 
            txtPermanentAddress.Location = new System.Drawing.Point(891, 249);
            txtPermanentAddress.Multiline = true;
            txtPermanentAddress.Name = "txtPermanentAddress";
            txtPermanentAddress.ReadOnly = true;
            txtPermanentAddress.Size = new System.Drawing.Size(132, 55);
            txtPermanentAddress.TabIndex = 12;
            // 
            // EmployeeListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1035, 450);
            Controls.Add(txtPermanentAddress);
            Controls.Add(txtPresentAddress);
            Controls.Add(picPhoto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearchMobileNo);
            Controls.Add(txtSearchName);
            Controls.Add(dataGridView1);
            Name = "EmployeeListForm";
            Text = "EmployeeList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchMobileNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.TextBox txtPresentAddress;
        private System.Windows.Forms.TextBox txtPermanentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJointDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInitialSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaritalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender;
    }
}