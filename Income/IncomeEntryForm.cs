// IncomeEntryForm.cs using System; using System.Data; using System.Data.SQLite; using System.Windows.Forms;

using System.Data.SQLite;
using System.Windows.Forms;
using System;

namespace NotebookWinFormsApp
{
    public partial class IncomeEntryForm : Form
    {
        private bool isEditMode = false;

        public IncomeEntryForm()
        {
            InitializeComponent();
            Load += IncomeEntryForm_Load;
            cmbShopName.TextChanged += cmbShopName_TextChanged;
        }

        private void IncomeEntryForm_Load(object sender, EventArgs e)
        {
            dtpMonth.Value = DateTime.Today;
            LoadShopNames();
        }

        private void LoadShopNames()
        {
            cmbShopName.Items.Clear();
            using (var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT ShopName FROM Shops", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbShopName.Items.Add(reader["ShopName"].ToString());
                    }
                }
            }
            cmbShopName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbShopName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbShopName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbShopName.Text))
            {
                lblOwner.Text = lblMobile.Text = lblAddress.Text = "";
                return;
            }

            using (var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT OwnerName, Mobile, Address FROM Shops WHERE ShopName = @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", cmbShopName.Text.Trim());
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblOwner.Text = reader["OwnerName"].ToString();
                            lblMobile.Text = reader["Mobile"].ToString();
                            lblAddress.Text = reader["Address"].ToString();
                        }
                        else
                        {
                            lblOwner.Text = lblMobile.Text = lblAddress.Text = "";
                        }
                    }
                }
            }
        }

        private void btnAutoDate_Click(object sender, EventArgs e)
        {
            dgvIncome.Rows.Clear();
            DateTime firstDay = new DateTime(dtpMonth.Value.Year, dtpMonth.Value.Month, 1);
            int days = DateTime.DaysInMonth(firstDay.Year, firstDay.Month);
            for (int i = 0; i < days; i++)
            {
                string date = firstDay.AddDays(i).ToString("dd/MM/yyyy");
                int rowIndex = dgvIncome.Rows.Add(date, "");
                if (!isEditMode && firstDay.AddDays(i).Date != DateTime.Today.Date)
                {
                    dgvIncome.Rows[rowIndex].ReadOnly = true;
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dgvIncome.Rows.Clear();
            string shopName = cmbShopName.Text.Trim();
            DateTime selectedDate = dtpMonth.Value;
            DateTime firstDay = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            int days = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
            decimal monthlyTotal = 0;

            using (var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;"))
            {
                conn.Open();
                for (int i = 0; i < days; i++)
                {
                    string date = firstDay.AddDays(i).ToString("yyyy-MM-dd");
                    string query = "SELECT Amount FROM Income WHERE ShopName = @name AND IncomeDate = @date";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", shopName);
                        cmd.Parameters.AddWithValue("@date", date);
                        object result = cmd.ExecuteScalar();
                        string amount = result != null ? Convert.ToDecimal(result).ToString("0.00") : "";
                        int rowIndex = dgvIncome.Rows.Add(firstDay.AddDays(i).ToString("dd/MM/yyyy"), amount);

                        if (!isEditMode && firstDay.AddDays(i).Date != DateTime.Today.Date)
                        {
                            dgvIncome.Rows[rowIndex].ReadOnly = true;
                        }
                        if (decimal.TryParse(amount, out decimal a))
                            monthlyTotal += a;
                    }

                }
                lblMonthlyAmount.Text = monthlyTotal.ToString("0.00");

                string yearQuery = "SELECT SUM(Amount) FROM Income WHERE ShopName = @name AND strftime('%Y', IncomeDate) = @year";
                using (var cmd = new SQLiteCommand(yearQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@name", shopName);
                    cmd.Parameters.AddWithValue("@year", dtpMonth.Value.Year.ToString());
                    object yearResult = cmd.ExecuteScalar();
                    lblYearAmount.Text = yearResult != DBNull.Value ? Convert.ToDecimal(yearResult).ToString("0.00") : "0.00";
                }
            }
        }

        private void btnSaveIncome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbShopName.Text))
            {
                MessageBox.Show("Please select a Shop Name.");
                return;
            }

            string shopName = cmbShopName.Text.Trim();
            string shopCode = GetShopCodeByName(shopName);
            string createdBy = "ADMIN";
            string createdAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            using (var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;"))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    foreach (DataGridViewRow row in dgvIncome.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string dateText = Convert.ToDateTime(row.Cells[0].Value).ToString("yyyy-MM-dd");
                        string amountText = Convert.ToString(row.Cells[1].Value)?.Trim();

                        // যদি এমাউন্ট খালি থাকে তাহলে সেই ডেটের ইনকাম ডিলিট হবে
                        if (string.IsNullOrWhiteSpace(amountText))
                        {
                            var deleteCmd = new SQLiteCommand("DELETE FROM Income WHERE ShopCode = @code AND IncomeDate = @date", conn, transaction);
                            deleteCmd.Parameters.AddWithValue("@code", shopCode);
                            deleteCmd.Parameters.AddWithValue("@date", dateText);
                            deleteCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            decimal amount = Convert.ToDecimal(amountText);

                            // আগে ডেটা থাকলে ডিলিট করে তারপর ইনসার্ট
                            var deleteCmd = new SQLiteCommand("DELETE FROM Income WHERE ShopCode = @code AND IncomeDate = @date", conn, transaction);
                            deleteCmd.Parameters.AddWithValue("@code", shopCode);
                            deleteCmd.Parameters.AddWithValue("@date", dateText);
                            deleteCmd.ExecuteNonQuery();

                            var insertCmd = new SQLiteCommand("INSERT INTO Income (ShopCode, ShopName, IncomeDate, Amount, CreatedBy, CreatedAt) VALUES (@code, @name, @date, @amount, @by, @at)", conn, transaction);
                            insertCmd.Parameters.AddWithValue("@code", shopCode);
                            insertCmd.Parameters.AddWithValue("@name", shopName);
                            insertCmd.Parameters.AddWithValue("@date", dateText);
                            insertCmd.Parameters.AddWithValue("@amount", amount);
                            insertCmd.Parameters.AddWithValue("@by", createdBy);
                            insertCmd.Parameters.AddWithValue("@at", createdAt);
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
            }

            MessageBox.Show("Income saved successfully.");
            btnLoadData.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditMode = true;
            foreach (DataGridViewRow row in dgvIncome.Rows)
            {
                row.ReadOnly = false;
            }
        }

        private string GetShopCodeByName(string name)
        {
            using (var conn = new SQLiteConnection("Data Source=Notebook.db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT ShopCode FROM Shops WHERE ShopName = @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "";
                }
            }
        }

        private void dgvIncome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{DOWN}");
            }
        }
    }

}