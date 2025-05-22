using System; // 1
using System.Windows.Forms; // 2
                            // 3
namespace NotebookWinFormsApp // 4
{ // 5
    public partial class ShopAccessForm : Form // 6
    { // 7
        private const string correctPassword = "123"; // এখানে পাসওয়ার্ড সেট করো // 8
                                                           // 9
        public ShopAccessForm() // 10
        { // 11
            InitializeComponent(); // 12

        } // 13
          // 14
        private void btnOK_Click(object sender, EventArgs e) // 15
        { // 16
            if (txtPassword.Text == correctPassword) // 17
            { // 18
                this.DialogResult = DialogResult.OK; // 19
                this.Close(); // 20
            } // 21
            else // 22
            { // 23
                MessageBox.Show("Incorrect password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 24
                txtPassword.Clear(); // 25
                txtPassword.Focus(); // 26
            } // 27
        } // 28
          // 29
        private void btnCancel_Click(object sender, EventArgs e) // 30
        { // 31
            this.DialogResult = DialogResult.Cancel; // 32
            this.Close(); // 33
        } // 34
          // 35
        private void ShopAccessForm_Load(object sender, EventArgs e) // 36
        { // 37
            txtPassword.Focus(); // 38
        } // 39
    } // 40
} // 41
