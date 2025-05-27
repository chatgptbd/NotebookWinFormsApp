using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    partial class BonusEntryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBonusPercent;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dtpBonusDate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBonusDate;
        private System.Windows.Forms.Label lblBonusPercent;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            txtBonusPercent = new TextBox();
            txtTotalAmount = new TextBox();
            txtNote = new TextBox();
            dtpBonusDate = new DateTimePicker();
            btnNew = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnGetData = new Button();
            btnClose = new Button();
            lblBonusDate = new Label();
            lblBonusPercent = new Label();
            lblNote = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView1.Location = new System.Drawing.Point(20, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(614, 358);
            dataGridView1.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Emp Code";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Mobile No";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Salary";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Bonus %";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Bonus Amount";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // txtBonusPercent
            // 
            txtBonusPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtBonusPercent.Location = new System.Drawing.Point(120, 52);
            txtBonusPercent.Name = "txtBonusPercent";
            txtBonusPercent.Size = new System.Drawing.Size(100, 29);
            txtBonusPercent.TabIndex = 1;
            txtBonusPercent.TextChanged += txtBonusPercent_TextChanged;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTotalAmount.Location = new System.Drawing.Point(524, 95);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new System.Drawing.Size(100, 29);
            txtTotalAmount.TabIndex = 10;
            // 
            // txtNote
            // 
            txtNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNote.Location = new System.Drawing.Point(120, 87);
            txtNote.Name = "txtNote";
            txtNote.Size = new System.Drawing.Size(244, 29);
            txtNote.TabIndex = 2;
            // 
            // dtpBonusDate
            // 
            dtpBonusDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpBonusDate.Format = DateTimePickerFormat.Short;
            dtpBonusDate.Location = new System.Drawing.Point(120, 17);
            dtpBonusDate.Name = "dtpBonusDate";
            dtpBonusDate.Size = new System.Drawing.Size(130, 29);
            dtpBonusDate.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNew.Location = new System.Drawing.Point(685, 115);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(91, 29);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(685, 152);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(91, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(685, 226);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(91, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(685, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(91, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGetData
            // 
            btnGetData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGetData.Location = new System.Drawing.Point(685, 189);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new System.Drawing.Size(91, 29);
            btnGetData.TabIndex = 5;
            btnGetData.Text = "Get Data";
            btnGetData.Click += btnGetData_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(685, 300);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(91, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // lblBonusDate
            // 
            lblBonusDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBonusDate.Location = new System.Drawing.Point(20, 20);
            lblBonusDate.Name = "lblBonusDate";
            lblBonusDate.Size = new System.Drawing.Size(100, 23);
            lblBonusDate.TabIndex = 0;
            lblBonusDate.Text = "Bonus Date:";
            // 
            // lblBonusPercent
            // 
            lblBonusPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBonusPercent.Location = new System.Drawing.Point(20, 55);
            lblBonusPercent.Name = "lblBonusPercent";
            lblBonusPercent.Size = new System.Drawing.Size(100, 23);
            lblBonusPercent.TabIndex = 2;
            lblBonusPercent.Text = "Bonus %:";
            // 
            // lblNote
            // 
            lblNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNote.Location = new System.Drawing.Point(20, 90);
            lblNote.Name = "lblNote";
            lblNote.Size = new System.Drawing.Size(100, 23);
            lblNote.TabIndex = 6;
            lblNote.Text = "Note:";
            // 
            // lblTotal
            // 
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTotal.Location = new System.Drawing.Point(410, 98);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(108, 23);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total Bonus:";
            // 
            // BonusEntryForm
            // 
            ClientSize = new System.Drawing.Size(805, 500);
            Controls.Add(lblBonusDate);
            Controls.Add(dtpBonusDate);
            Controls.Add(lblBonusPercent);
            Controls.Add(txtBonusPercent);
            Controls.Add(lblTotal);
            Controls.Add(txtTotalAmount);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(dataGridView1);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnGetData);
            Controls.Add(btnClose);
            Name = "BonusEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bonus Entry Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}