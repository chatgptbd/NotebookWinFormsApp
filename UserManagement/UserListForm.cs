using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class UserListForm : Form
    {
        public UserManagementForm ManagementForm { get; set; }

        public UserListForm()
        {
            InitializeComponent();
            LoadUsernames();
            LoadAllUsers();
        }

        private void LoadUsernames()
        {
            cmbUsernameSearch.Items.Clear();

            using var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;");
            conn.Open();

            string query = "SELECT DISTINCT Username FROM Users ORDER BY Username";
            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmbUsernameSearch.Items.Add(reader["Username"].ToString());
            }

            cmbUsernameSearch.DropDownStyle = ComboBoxStyle.DropDown;
            cmbUsernameSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUsernameSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadAllUsers()
        {
            dataGridView1.Rows.Clear();

            using var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;");
            conn.Open();

            string query = "SELECT UserCode, FullName, Username, Password, Role FROM Users ORDER BY ID";
            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader["UserCode"].ToString(),
                    reader["FullName"].ToString(),
                    reader["Username"].ToString(),
                    reader["Password"].ToString(),
                    reader["Role"].ToString()
                );
            }
        }

        private void cmbUsernameSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = cmbUsernameSearch.Text.Trim().ToLower();
            dataGridView1.Rows.Clear();

            using var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;");
            conn.Open();

            string query = "SELECT UserCode, FullName, Username, Password, Role FROM Users WHERE LOWER(Username) LIKE @search ORDER BY ID";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@search", $"%{searchText}%");

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader["UserCode"].ToString(),
                    reader["FullName"].ToString(),
                    reader["Username"].ToString(),
                    reader["Password"].ToString(),
                    reader["Role"].ToString()
                );
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {
                string userCode = dataGridView1.CurrentRow.Cells["colUserCode"].Value.ToString();
                string fullName = dataGridView1.CurrentRow.Cells["colFullName"].Value.ToString();
                string username = dataGridView1.CurrentRow.Cells["colUsername"].Value.ToString();
                string password = dataGridView1.CurrentRow.Cells["colPassword"].Value.ToString();
                string role = dataGridView1.CurrentRow.Cells["colRole"].Value.ToString();

                if (ManagementForm is UserManagementForm targetForm)
                {
                    targetForm.SetUserData(userCode, fullName, username, password, role);
                }

                this.Close();
            }
        }
    }
}