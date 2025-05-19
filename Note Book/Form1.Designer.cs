namespace NotebookSQLiteApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblReverseNo;
        private System.Windows.Forms.TextBox txtReverseNo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblID = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            lblModel = new System.Windows.Forms.Label();
            txtModel = new System.Windows.Forms.TextBox();
            lblReverseNo = new System.Windows.Forms.Label();
            txtReverseNo = new System.Windows.Forms.TextBox();
            lblDescription = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            btnNew = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnGetData = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblID.Location = new System.Drawing.Point(30, 30);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(100, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtID.Location = new System.Drawing.Point(130, 30);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new System.Drawing.Size(75, 29);
            txtID.TabIndex = 1;
            // 
            // lblModel
            // 
            lblModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblModel.Location = new System.Drawing.Point(30, 70);
            lblModel.Name = "lblModel";
            lblModel.Size = new System.Drawing.Size(100, 23);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtModel.Location = new System.Drawing.Point(130, 70);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(275, 29);
            txtModel.TabIndex = 3;
            // 
            // lblReverseNo
            // 
            lblReverseNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblReverseNo.Location = new System.Drawing.Point(30, 110);
            lblReverseNo.Name = "lblReverseNo";
            lblReverseNo.Size = new System.Drawing.Size(100, 23);
            lblReverseNo.TabIndex = 4;
            lblReverseNo.Text = "Reverse No:";
            // 
            // txtReverseNo
            // 
            txtReverseNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtReverseNo.Location = new System.Drawing.Point(130, 110);
            txtReverseNo.Name = "txtReverseNo";
            txtReverseNo.Size = new System.Drawing.Size(275, 29);
            txtReverseNo.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDescription.Location = new System.Drawing.Point(30, 150);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(100, 23);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDescription.Location = new System.Drawing.Point(130, 146);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(275, 73);
            txtDescription.TabIndex = 7;
            // 
            // btnNew
            // 
            btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNew.Location = new System.Drawing.Point(437, 23);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(88, 34);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(437, 62);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(437, 100);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(88, 34);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(437, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(88, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGetData
            // 
            btnGetData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGetData.Location = new System.Drawing.Point(437, 179);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new System.Drawing.Size(88, 34);
            btnGetData.TabIndex = 12;
            btnGetData.Text = "Get Data";
            btnGetData.Click += btnGetData_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(437, 219);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 34);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(544, 265);
            Controls.Add(lblID);
            Controls.Add(txtID);
            Controls.Add(lblModel);
            Controls.Add(txtModel);
            Controls.Add(lblReverseNo);
            Controls.Add(txtReverseNo);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnGetData);
            Controls.Add(btnClose);
            Name = "Form1";
            Text = "Notebook - Entry Form (Form1)";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
