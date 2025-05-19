using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Show/hide password
            txtPassword.UseSystemPasswordChar = true;
            chkShowPassword.CheckedChanged += (s, e) =>
            {
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            };

            // Enable Enter key for login
            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus(); // Auto-focus username box
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string connStr = "Data Source=Notebook.db;Version=3;";
            using var conn = new SQLiteConnection(connStr);
            conn.Open();

            string query = "SELECT COUNT(1) FROM Users WHERE Username = @u AND Password = @p";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
              //  MessageBox.Show("Login successful!");
                this.Hide();
                new DashboardForm().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact admin to reset your password.");
        }
    }
}
