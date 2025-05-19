namespace NotebookWinFormsApp
{
    partial class UserManagementForm
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
            txtFullName = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            cmbRole = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnNew = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnGetData = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtUserCode = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFullName.Location = new System.Drawing.Point(141, 68);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(239, 29);
            txtFullName.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUsername.Location = new System.Drawing.Point(141, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(239, 29);
            txtUsername.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new System.Drawing.Point(141, 174);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new System.Drawing.Size(260, 29);
            cmbRole.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(47, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 21);
            label1.TabIndex = 4;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(47, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 21);
            label2.TabIndex = 5;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(47, 179);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 21);
            label3.TabIndex = 6;
            label3.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(141, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(239, 29);
            txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(47, 142);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 21);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // btnNew
            // 
            btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNew.Location = new System.Drawing.Point(429, 27);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(98, 36);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(429, 66);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(98, 36);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnGetData
            // 
            btnGetData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGetData.Location = new System.Drawing.Point(429, 103);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new System.Drawing.Size(98, 36);
            btnGetData.TabIndex = 6;
            btnGetData.Text = "GetData";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(429, 141);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(98, 36);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(429, 181);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(98, 36);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(429, 223);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(98, 36);
            btnClose.TabIndex = 9;
            btnClose.Tag = "";
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(47, 35);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 21);
            label5.TabIndex = 16;
            label5.Text = "UserCode";
            // 
            // txtUserCode
            // 
            txtUserCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUserCode.Location = new System.Drawing.Point(141, 35);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new System.Drawing.Size(104, 29);
            txtUserCode.TabIndex = 17;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(547, 286);
            Controls.Add(txtUserCode);
            Controls.Add(label5);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnGetData);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbRole);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            Load += UserManagementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserCode;
    }
}