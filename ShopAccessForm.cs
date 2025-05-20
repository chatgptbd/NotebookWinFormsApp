using System;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class ShopAccessForm : Form
    {
        private const string correctPassword = "admin123"; // এখানে পাসওয়ার্ড সেট করো

        public ShopAccessForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == correctPassword)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ShopAccessForm_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}