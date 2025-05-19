using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            ClearForm(); // Form load time Auto Code and Clear
        }

        // 1. Auto-generate User Code
        private void GenerateUserCode()
        {
            using var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;");
            conn.Open();
            var cmd = new SQLiteCommand("SELECT IFNULL(MAX(ID), 0) + 1 FROM Users", conn);
            int nextId = Convert.ToInt32(cmd.ExecuteScalar());
            txtUserCode.Text = $"USR{nextId:0000}";
        }

        // 2. Clear All Fields and Focus FullName
        private void ClearForm()
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            GenerateUserCode();
            txtFullName.Focus();
        }

        // 3. Set data from UserListForm
        public void SetUserData(string code, string full, string user, string pass, string role)
        {
            txtUserCode.Text = code;
            txtFullName.Text = full;
            txtUsername.Text = user;
            txtPassword.Text = pass;
            cmbRole.Text = role;
            txtFullName.Focus() ;
        }

        // 4. Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || cmbRole.Text == "")
            {
                MessageBox.Show("All fields are required to save.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            using var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;");
            conn.Open();

            // Check for duplicate username
            var checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn);
            checkCmd.Parameters.AddWithValue("@username", txtUsername.Text);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Username already exists. Please choose another.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            var cmd = new SQLiteCommand("INSERT INTO Users (UserCode, FullName, Username, Password, Role) VALUES (@code, @full, @user, @pass, @role)", conn);
            cmd.Parameters.AddWithValue("@code", txtUserCode.Text);
            cmd.Parameters.AddWithValue("@full", txtFullName.Text);
            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            cmd.Parameters.AddWithValue("@role", cmbRole.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        // 5. Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserCode.Text == "" || txtFullName.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || cmbRole.Text == "")
            {
                MessageBox.Show("All fields are required to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            using var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;");
            conn.Open();

            var cmd = new SQLiteCommand("UPDATE Users SET FullName=@full, Username=@user, Password=@pass, Role=@role WHERE UserCode=@code", conn);
            cmd.Parameters.AddWithValue("@code", txtUserCode.Text);
            cmd.Parameters.AddWithValue("@full", txtFullName.Text);
            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            cmd.Parameters.AddWithValue("@role", cmbRole.Text);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
            }
        }

        // 6. Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserCode.Text == "")
            {
                MessageBox.Show("UserCode is required to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;");
            conn.Open();

            var cmd = new SQLiteCommand("DELETE FROM Users WHERE UserCode = @code", conn);
            cmd.Parameters.AddWithValue("@code", txtUserCode.Text);
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Delete failed. User not found.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
            }
        }

        // 7. GetData Button
        private void btnGetData_Click(object sender, EventArgs e)
        {
            var listForm = new UserListForm();
            listForm.ManagementForm = this;
            listForm.ShowDialog();
            txtFullName.Focus();
            return;
        }

        // 8. Close Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 9. Form Load
        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        // 10. New Button
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}