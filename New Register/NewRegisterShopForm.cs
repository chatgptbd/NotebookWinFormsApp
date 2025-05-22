// NewRegisterShopForm.cs
using System; 
using System.Data; 
using System.Data.SQLite; 
using System.Windows.Forms;



namespace NotebookWinFormsApp
{
    public partial class NewRegisterShopForm : Form
    {
        public TextBox TxtShopCode => txtShopCode; public TextBox TxtShopName => txtShopName; public TextBox TxtOwnerName => txtOwnerName; public TextBox TxtMobile => txtMobile; public TextBox TxtAddress => txtAddress; public TextBox TxtEmail => txtEmail; public ComboBox CmbShopType => cmbShopType; public DateTimePicker DtpOpeningDate => dtpOpeningDate; public TextBox TxtLicenseNo => txtLicenseNo; public ComboBox CmbStatus => cmbStatus;

        public NewRegisterShopForm()
        {
            InitializeComponent();
            txtShopCode.ReadOnly = true;
        }

        private void NewRegisterShopForm_Load(object sender, EventArgs e)
        {
            cmbShopType.Items.AddRange(new string[] { "Grocery", "Pharmacy", "Electronics", "Stationery" });
            cmbStatus.Items.AddRange(new string[] { "Active", "Inactive" });
            GenerateShopCode();
            txtShopName.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtShopName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtShopName.Text))
            {
                MessageBox.Show("Shop name is required.");
                txtShopName.Focus();
                return;
            }

            string connectionString = "Data Source=Notebook.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Shops WHERE ShopCode = @ShopCode";
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ShopCode", txtShopCode.Text);
                    long count = (long)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This Shop Code already exists. Please click 'Update'.");
                        txtShopName.Focus();
                        return;
                    }
                }

                string insertQuery = @"
                INSERT INTO Shops (ShopCode, ShopName, OwnerName, Mobile, Address, Email, ShopType, OpeningDate, LicenseNo, Status)
                VALUES (@ShopCode, @ShopName, @OwnerName, @Mobile, @Address, @Email, @ShopType, @OpeningDate, @LicenseNo, @Status)";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ShopCode", txtShopCode.Text);
                    cmd.Parameters.AddWithValue("@ShopName", txtShopName.Text);
                    cmd.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text);
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ShopType", cmbShopType.Text);
                    cmd.Parameters.AddWithValue("@OpeningDate", dtpOpeningDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@LicenseNo", txtLicenseNo.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Shop saved successfully!");
            ClearForm();
            GenerateShopCode();
            txtShopName.Focus();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            using (ShopListForm listForm = new ShopListForm(this))
            {
                listForm.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtShopCode.Text))
            {
                MessageBox.Show("No shop selected to update.");
                txtShopName.Focus();
                return;
            }

            string connectionString = "Data Source=Notebook.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string updateQuery = @"
                UPDATE Shops SET
                    ShopName = @ShopName,
                    OwnerName = @OwnerName,
                    Mobile = @Mobile,
                    Address = @Address,
                    Email = @Email,
                    ShopType = @ShopType,
                    OpeningDate = @OpeningDate,
                    LicenseNo = @LicenseNo,
                    Status = @Status
                WHERE ShopCode = @ShopCode";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ShopName", txtShopName.Text);
                    cmd.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text);
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ShopType", cmbShopType.Text);
                    cmd.Parameters.AddWithValue("@OpeningDate", dtpOpeningDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@LicenseNo", txtLicenseNo.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@ShopCode", txtShopCode.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Shop updated successfully.");
            ClearForm();
            GenerateShopCode();
            txtShopName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtShopCode.Text))
            {
                MessageBox.Show("No shop selected to delete.");
                txtShopName.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this shop?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=Notebook.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Shops WHERE ShopCode = @ShopCode";
                    using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ShopCode", txtShopCode.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Shop deleted successfully.");
                            ClearForm();
                            GenerateShopCode();
                            txtShopName.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Shop not found.");
                            txtShopName.Focus();
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtShopName.Clear();
            txtOwnerName.Clear();
            txtMobile.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            cmbShopType.SelectedIndex = -1;
            dtpOpeningDate.Value = DateTime.Now;
            txtLicenseNo.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void GenerateShopCode()
        {
            string connectionString = "Data Source=Notebook.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(ShopCode) FROM Shops WHERE ShopCode LIKE 'SHOP%'";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    string lastCode = result?.ToString();

                    int nextNumber = 1;
                    if (!string.IsNullOrEmpty(lastCode) && lastCode.Length > 4)
                    {
                        string numberPart = lastCode.Substring(4);
                        if (int.TryParse(numberPart, out int parsedNumber))
                        {
                            nextNumber = parsedNumber + 1;
                        }
                    }

                    txtShopCode.Text = "SHOP" + nextNumber.ToString("D5");
                }
            }
        }
    }

}