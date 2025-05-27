// AdvanceEntryForm.cs
using System; 
using System.Collections.Generic; 
using System.Data.SQLite; 
using System.Linq; 
using System.Windows.Forms;



namespace NotebookWinFormsApp
{
    public partial class AdvanceEntryForm : Form
    {
        private List<string> allEmployees = new List<string>(); private int selectedAdvanceId = -1;

        public AdvanceEntryForm()
        {
            InitializeComponent();
            this.Load += AdvanceEntryForm_Load;

            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            lstSuggestion.Click += lstSuggestion_Click;
        }

        private void AdvanceEntryForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
            lstSuggestion.Visible = false;
            txtSearch.Focus();
        }

        private void LoadEmployeeList()
        {
            allEmployees.Clear();
            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = "SELECT EmpCode || ' - ' || Name AS DisplayText FROM Employee ORDER BY Name";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allEmployees.Add(reader["DisplayText"].ToString());
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(search))
            {
                lstSuggestion.Visible = false;
                return;
            }

            var filtered = allEmployees
                .Where(x => x.ToLower().Contains(search))
                .ToList();

            lstSuggestion.DataSource = filtered;
            lstSuggestion.Visible = filtered.Count > 0;
            lstSuggestion.Height = Math.Min(120, lstSuggestion.ItemHeight * filtered.Count + 5);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (!lstSuggestion.Visible || lstSuggestion.Items.Count == 0) return;

            if (e.KeyCode == Keys.Down)
            {
                if (lstSuggestion.SelectedIndex < lstSuggestion.Items.Count - 1)
                    lstSuggestion.SelectedIndex++;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (lstSuggestion.SelectedIndex > 0)
                    lstSuggestion.SelectedIndex--;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (lstSuggestion.SelectedItem != null)
                {
                    txtSearch.Text = lstSuggestion.SelectedItem.ToString();
                    txtSearch.SelectionStart = txtSearch.Text.Length;
                    txtSearch.SelectionLength = 0;
                    txtSearch.Focus();
                    lstSuggestion.Visible = false;
                    e.Handled = true;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstSuggestion.Visible = false;
                e.Handled = true;
            }
        }

        private void lstSuggestion_Click(object sender, EventArgs e)
        {
            if (lstSuggestion.SelectedItem != null)
            {
                txtSearch.Text = lstSuggestion.SelectedItem.ToString();
                txtSearch.SelectionStart = txtSearch.Text.Length;
                txtSearch.SelectionLength = 0;
                txtSearch.Focus();
                lstSuggestion.Visible = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtAmount.Text = "0.00";
            txtInstallment.Text = "0.00";
            txtNote.Text = "";
            dtpAdvanceDate.Value = DateTime.Today;
            dtpStartMonth.Value = DateTime.Today;
            txtSearch.Focus();
            lstSuggestion.Visible = false;
            selectedAdvanceId = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedAdvanceId != -1)
            {
                MessageBox.Show("This is an existing record. Please use Update instead.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSearch.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                Convert.ToDouble(txtAmount.Text) <= 0)
            {
                MessageBox.Show("Please enter valid employee and amount.");
                txtSearch.Focus();
                return;
            }

            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = "INSERT INTO Advance (EmpCode, AdvanceDate, Amount, InstallmentAmount, StartMonth, RemainingAmount, Note) " +
                               "VALUES (@EmpCode, @AdvanceDate, @Amount, @InstallmentAmount, @StartMonth, @RemainingAmount, @Note)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    string empCode = txtSearch.Text.Split('-')[0].Trim();
                    cmd.Parameters.AddWithValue("@EmpCode", empCode);
                    cmd.Parameters.AddWithValue("@AdvanceDate", dtpAdvanceDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@InstallmentAmount", Convert.ToDouble(txtInstallment.Text));
                    cmd.Parameters.AddWithValue("@StartMonth", dtpStartMonth.Value.ToString("yyyy-MM"));
                    cmd.Parameters.AddWithValue("@RemainingAmount", Convert.ToDouble(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Advance saved successfully.");
            btnNew_Click(sender, e);
        }

        public void LoadAdvanceData(string empCode, DateTime date, string amount, string note, int id)
        {
            txtSearch.Text = empCode; // EMP001 - md osman molla
            dtpAdvanceDate.Value = date;
            txtAmount.Text = amount;
            txtNote.Text = note;
            selectedAdvanceId = id;

            lstSuggestion.Visible = false; // লিস্ট লুকানো
            txtSearch.Focus(); // ফোকাস বক্সে
            txtSearch.SelectionStart = txtSearch.Text.Length; // ফোকাস শেষে
            txtSearch.SelectionLength = 0;
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            AdvanceListForm listForm = new AdvanceListForm(this);
            listForm.ShowDialog();
            txtSearch.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAdvanceId == -1)
            {
                MessageBox.Show("No record selected to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSearch.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                Convert.ToDouble(txtAmount.Text) <= 0)
            {
                MessageBox.Show("Please enter valid employee and amount.");
                txtSearch.Focus();
                return;
            }

            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = @"UPDATE Advance 
                             SET EmpCode = @EmpCode, 
                                 AdvanceDate = @AdvanceDate, 
                                 Amount = @Amount, 
                                 InstallmentAmount = @InstallmentAmount, 
                                 StartMonth = @StartMonth, 
                                 RemainingAmount = @RemainingAmount, 
                                 Note = @Note 
                             WHERE Id = @Id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    string empCode = txtSearch.Text.Split('-')[0].Trim();
                    cmd.Parameters.AddWithValue("@EmpCode", empCode);
                    cmd.Parameters.AddWithValue("@AdvanceDate", dtpAdvanceDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@InstallmentAmount", Convert.ToDouble(txtInstallment.Text));
                    cmd.Parameters.AddWithValue("@StartMonth", dtpStartMonth.Value.ToString("yyyy-MM"));
                    cmd.Parameters.AddWithValue("@RemainingAmount", Convert.ToDouble(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());
                    cmd.Parameters.AddWithValue("@Id", selectedAdvanceId);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Advance updated successfully.");
            btnNew_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (selectedAdvanceId == -1)
            {
                MessageBox.Show("No record selected to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection("Data Source=notebook.db"))
                {
                    conn.Open();
                    string query = "DELETE FROM Advance WHERE Id = @Id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedAdvanceId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Advance deleted successfully.");
                btnNew_Click(sender, e); // ক্লিয়ার করে ফর্ম নতুন অবস্থায় আনবে
                txtSearch.Focus(); // সার্চ টেক্সবক্সে ফোকাস
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
