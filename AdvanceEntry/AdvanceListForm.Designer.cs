namespace NotebookWinFormsApp
{
    partial class AdvanceListForm
    {
        private System.ComponentModel.IContainer components = null; private System.Windows.Forms.TextBox txtSearchName; private System.Windows.Forms.TextBox txtSearchMobile; private System.Windows.Forms.Label lblSearchName; private System.Windows.Forms.Label lblSearchMobile; private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSearchName = new System.Windows.Forms.TextBox();
            txtSearchMobile = new System.Windows.Forms.TextBox();
            lblSearchName = new System.Windows.Forms.Label();
            lblSearchMobile = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColEmpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColAdvanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColInstallment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColStartMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new System.Drawing.Point(96, 14);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new System.Drawing.Size(176, 23);
            txtSearchName.TabIndex = 0;
            // 
            // txtSearchMobile
            // 
            txtSearchMobile.Location = new System.Drawing.Point(407, 14);
            txtSearchMobile.Name = "txtSearchMobile";
            txtSearchMobile.Size = new System.Drawing.Size(132, 23);
            txtSearchMobile.TabIndex = 1;
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Location = new System.Drawing.Point(18, 17);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new System.Drawing.Size(77, 15);
            lblSearchName.TabIndex = 2;
            lblSearchName.Text = "Search Name";
            // 
            // lblSearchMobile
            // 
            lblSearchMobile.AutoSize = true;
            lblSearchMobile.Location = new System.Drawing.Point(289, 17);
            lblSearchMobile.Name = "lblSearchMobile";
            lblSearchMobile.Size = new System.Drawing.Size(82, 15);
            lblSearchMobile.TabIndex = 3;
            lblSearchMobile.Text = "Search Mobile";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColId, ColEmpCode, ColName, ColMobileNo, ColAdvanceDate, ColAmount, ColInstallment, ColStartMonth, ColRemaining, ColNote });
            dataGridView1.Location = new System.Drawing.Point(18, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(1187, 472);
            dataGridView1.TabIndex = 4;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 80;
            // 
            // ColEmpCode
            // 
            ColEmpCode.DataPropertyName = "EmpCode";
            ColEmpCode.HeaderText = "Emp Code";
            ColEmpCode.Name = "ColEmpCode";
            ColEmpCode.ReadOnly = true;
            // 
            // ColName
            // 
            ColName.DataPropertyName = "Name";
            ColName.HeaderText = "Name";
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            ColName.Width = 200;
            // 
            // ColMobileNo
            // 
            ColMobileNo.DataPropertyName = "MobileNo";
            ColMobileNo.HeaderText = "Mobile No";
            ColMobileNo.Name = "ColMobileNo";
            ColMobileNo.ReadOnly = true;
            // 
            // ColAdvanceDate
            // 
            ColAdvanceDate.DataPropertyName = "AdvanceDate";
            ColAdvanceDate.HeaderText = "Advance Date";
            ColAdvanceDate.Name = "ColAdvanceDate";
            ColAdvanceDate.ReadOnly = true;
            ColAdvanceDate.Width = 120;
            // 
            // ColAmount
            // 
            ColAmount.DataPropertyName = "Amount";
            ColAmount.HeaderText = "Amount";
            ColAmount.Name = "ColAmount";
            ColAmount.ReadOnly = true;
            // 
            // ColInstallment
            // 
            ColInstallment.DataPropertyName = "Installment";
            ColInstallment.HeaderText = "Installment";
            ColInstallment.Name = "ColInstallment";
            ColInstallment.ReadOnly = true;
            // 
            // ColStartMonth
            // 
            ColStartMonth.DataPropertyName = "StartMonth";
            ColStartMonth.HeaderText = "Start Month";
            ColStartMonth.Name = "ColStartMonth";
            ColStartMonth.ReadOnly = true;
            // 
            // ColRemaining
            // 
            ColRemaining.DataPropertyName = "Remaining";
            ColRemaining.HeaderText = "Remaining";
            ColRemaining.Name = "ColRemaining";
            ColRemaining.ReadOnly = true;
            // 
            // ColNote
            // 
            ColNote.DataPropertyName = "Note";
            ColNote.HeaderText = "Note";
            ColNote.Name = "ColNote";
            ColNote.ReadOnly = true;
            // 
            // AdvanceListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1217, 531);
            Controls.Add(dataGridView1);
            Controls.Add(lblSearchMobile);
            Controls.Add(lblSearchName);
            Controls.Add(txtSearchMobile);
            Controls.Add(txtSearchName);
            Name = "AdvanceListForm";
            Text = "Advance List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAdvanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNote;
    }

}