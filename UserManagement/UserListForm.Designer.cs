// UserListForm.Designer.cs

namespace NotebookWinFormsApp
{
    partial class UserListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbUsernameSearch = new System.Windows.Forms.ComboBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            colUserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbUsernameSearch
            // 
            cmbUsernameSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbUsernameSearch.FormattingEnabled = true;
            cmbUsernameSearch.Location = new System.Drawing.Point(42, 39);
            cmbUsernameSearch.Name = "cmbUsernameSearch";
            cmbUsernameSearch.Size = new System.Drawing.Size(227, 29);
            cmbUsernameSearch.TabIndex = 0;
            cmbUsernameSearch.TextChanged += cmbUsernameSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colUserCode, colUsername, colFullName, colPassword, colRole });
            dataGridView1.Location = new System.Drawing.Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(739, 325);
            dataGridView1.TabIndex = 1;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(70, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 21);
            label1.TabIndex = 2;
            label1.Text = "Search Name";
            // 
            // colUserCode
            // 
            colUserCode.HeaderText = "User Code";
            colUserCode.Name = "colUserCode";
            colUserCode.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "User Name";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 200;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.Width = 200;
            // 
            // colPassword
            // 
            colPassword.HeaderText = "Password";
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 150;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(763, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(cmbUsernameSearch);
            Name = "UserListForm";
            Text = "UserListForm";
        
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsernameSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
    }

}