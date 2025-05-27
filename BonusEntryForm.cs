using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class BonusEntryForm : Form
    {
        string connectionString = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "notebook.db;Version=3;";
        string currentBonusId = "";
        private BonusListForm bonusListFormInstance = null;

        public BonusEntryForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadEmployeeList();
            dtpBonusDate.Focus();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("EmpCode", "Emp Code");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("MobileNo", "Mobile No");
            dataGridView1.Columns.Add("Salary", "Salary");
            dataGridView1.Columns.Add("BonusPercent", "Bonus %");
            dataGridView1.Columns.Add("BonusAmount", "Bonus Amount");
        }

        private void LoadEmployeeList()
        {
            dataGridView1.Rows.Clear();

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT EmpCode, Name, MobileNo, InitialSalary FROM Employee";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["EmpCode"].ToString(),
                        reader["Name"].ToString(),
                        reader["MobileNo"].ToString(),
                        reader["InitialSalary"].ToString(),
                        "",
                        ""
                    );
                }
            }
        }

        private void txtBonusPercent_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBonusPercent.Text, out decimal percent)) return;

            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells["Salary"].Value?.ToString(), out decimal salary))
                {
                    decimal bonusAmount = salary * (percent / 100);
                    row.Cells["BonusPercent"].Value = percent;
                    row.Cells["BonusAmount"].Value = Math.Round(bonusAmount, 2);
                    total += bonusAmount;
                }
            }

            txtTotalAmount.Text = total.ToString("0.00");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBonusPercent.Clear();
            txtNote.Clear();
            txtTotalAmount.Clear();
            dtpBonusDate.Value = DateTime.Today;
            LoadEmployeeList();
            currentBonusId = "";
            dtpBonusDate.Focus();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBonusPercent.Text))
            {
                MessageBox.Show("অনুগ্রহ করে Bonus % প্রদান করুন।", "সতর্কতা", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpBonusDate.Focus();
                return;
            }

            string selectedMonth = dtpBonusDate.Value.ToString("yyyy-MM");
            string query = "SELECT COUNT(*) FROM Bonus WHERE strftime('%Y-%m', BonusDate) = @Month";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@Month", selectedMonth);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("এই মাসে একটি বোনাস ইতিমধ্যে সেভ করা হয়েছে। অনুগ্রহ করে আপডেট করুন।", "সতর্কতা", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveBonusRecords();
                MessageBox.Show("বোনাস সেভ সফল হয়েছে।", "সফল", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpBonusDate.Focus();
            }
        }


        private void SaveBonusRecords()
        {
            string insertId = Guid.NewGuid().ToString();
            currentBonusId = insertId;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string empCode = row.Cells["EmpCode"].Value?.ToString();
                string bonusPercent = row.Cells["BonusPercent"].Value?.ToString();
                string bonusAmount = row.Cells["BonusAmount"].Value?.ToString();

                if (string.IsNullOrEmpty(empCode)) continue;

                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Bonus (BonusId, EmpCode, BonusDate, BonusPercent, BonusAmount, Note, CreatedAt) " +
                                   "VALUES (@BonusId, @EmpCode, @BonusDate, @BonusPercent, @BonusAmount, @Note, @CreatedAt)";

                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@BonusId", insertId);
                    cmd.Parameters.AddWithValue("@EmpCode", empCode);
                    cmd.Parameters.AddWithValue("@BonusDate", dtpBonusDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@BonusPercent", bonusPercent);
                    cmd.Parameters.AddWithValue("@BonusAmount", bonusAmount);
                    cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());
                    cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentBonusId))
            {
                MessageBox.Show("আপনি কোন বোনাস লোড করেননি।", "ত্রুটি", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                SQLiteCommand del = new SQLiteCommand("DELETE FROM Bonus WHERE BonusId = @BonusId", con);
                del.Parameters.AddWithValue("@BonusId", currentBonusId);
                del.ExecuteNonQuery();
            }

            SaveBonusRecords();
            MessageBox.Show("বোনাস আপডেট সফল হয়েছে।", "সফল", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBonusPercent.Clear();
            txtNote.Clear();
            txtTotalAmount.Clear();
            dtpBonusDate.Value = DateTime.Today;
            LoadEmployeeList();
            currentBonusId = "";
            dtpBonusDate.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentBonusId))
            {
                MessageBox.Show("আপনি কোন বোনাস লোড করেননি।", "ত্রুটি", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("আপনি কি নিশ্চিতভাবে এই বোনাসটি ডিলিট করতে চান?", "নিশ্চিতকরণ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    SQLiteCommand del = new SQLiteCommand("DELETE FROM Bonus WHERE BonusId = @BonusId", con);
                    del.Parameters.AddWithValue("@BonusId", currentBonusId);
                    del.ExecuteNonQuery();
                }

                btnNew.PerformClick();
                MessageBox.Show("বোনাস ডিলিট হয়েছে।", "সফল", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBonusPercent.Clear();
                txtNote.Clear();
                txtTotalAmount.Clear();
                dtpBonusDate.Value = DateTime.Today;
                LoadEmployeeList();
                currentBonusId = "";
                dtpBonusDate.Focus();
            }
        }

        // BonusListForm থেকে BonusId দিয়ে ডেটা লোড হবে
        public void LoadBonusData(string bonusId, string bonusDate, string bonusPercent, string note)
        {
            currentBonusId = bonusId;
            dtpBonusDate.Text = bonusDate;
            txtBonusPercent.Text = bonusPercent;
            txtNote.Text = note;
            dtpBonusDate.Focus();
            dataGridView1.Rows.Clear();

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT b.EmpCode, e.Name, e.MobileNo, e.InitialSalary, b.BonusPercent, b.BonusAmount " +
                               "FROM Bonus b INNER JOIN Employee e ON b.EmpCode = e.EmpCode WHERE b.BonusId = @BonusId";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@BonusId", bonusId);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["EmpCode"].ToString(),
                        reader["Name"].ToString(),
                        reader["MobileNo"].ToString(),
                        reader["InitialSalary"].ToString(),
                        reader["BonusPercent"].ToString(),
                        reader["BonusAmount"].ToString()
                    );
                }
            }
        }


       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (bonusListFormInstance == null || bonusListFormInstance.IsDisposed)
            {
                bonusListFormInstance = new BonusListForm(this);
                bonusListFormInstance.FormClosed += (s, args) => bonusListFormInstance = null;
                bonusListFormInstance.Show();
            }
            else
            {
                bonusListFormInstance.BringToFront();
                dtpBonusDate.Focus();
            }
        }

        private void lblBonusPercent_Click(object sender, EventArgs e)
        {

        }
    }
}
