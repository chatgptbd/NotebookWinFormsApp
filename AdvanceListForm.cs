using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class AdvanceListForm : Form
    {
        private AdvanceEntryForm parentForm;

        public AdvanceListForm(AdvanceEntryForm parent)
        {
            InitializeComponent();
            parentForm = parent;
            this.Load += AdvanceListForm_Load;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            txtSearchName.KeyDown += TxtSearchName_KeyDown;
            dataGridView1.KeyDown += DataGridView1_KeyDown;
        }

        private void AdvanceListForm_Load(object sender, EventArgs e)
        {
            txtSearchName.TextChanged += (s, ev) => LoadData(txtSearchName.Text, txtSearchMobile.Text);
            txtSearchMobile.TextChanged += (s, ev) => LoadData(txtSearchName.Text, txtSearchMobile.Text);
            LoadData("", "");
            txtSearchName.Focus();
        }

        private void LoadData(string name, string mobile)
        {
            dataGridView1.Rows.Clear();
            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = @"SELECT A.Id, A.EmpCode, E.Name, E.MobileNo, A.AdvanceDate, A.Amount, 
                                A.InstallmentAmount, A.StartMonth, A.RemainingAmount, A.Note
                                FROM Advance A
                                JOIN Employee E ON A.EmpCode = E.EmpCode
                                WHERE (E.Name LIKE @name OR @name = '') AND (E.MobileNo LIKE @mobile OR @mobile = '')
                                ORDER BY A.AdvanceDate DESC";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", $"%{name}%");
                    cmd.Parameters.AddWithValue("@mobile", $"%{mobile}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["Id"], reader["EmpCode"], reader["Name"], reader["MobileNo"],
                                Convert.ToDateTime(reader["AdvanceDate"]).ToString("yyyy-MM-dd"),
                                reader["Amount"], reader["InstallmentAmount"],
                                Convert.ToDateTime(reader["StartMonth"]).ToString("yyyy-MM"),
                                reader["RemainingAmount"], reader["Note"]
                            );
                        }
                    }
                }
            }
        }

        private void TxtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.Focus();
                e.Handled = true;
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {
                SendDataToEntryForm();
                e.Handled = true;
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SendDataToEntryForm();
            }
        }

        private void SendDataToEntryForm()
        {
            var row = dataGridView1.CurrentRow;
            int id = Convert.ToInt32(row.Cells["ColId"].Value);
            string empCode = row.Cells["ColEmpCode"].Value.ToString();
            string name = row.Cells["ColName"].Value.ToString();
            DateTime advDate = DateTime.Parse(row.Cells["ColAdvanceDate"].Value.ToString());
            string amount = row.Cells["ColAmount"].Value.ToString();
            string note = row.Cells["ColNote"].Value.ToString();

            string empDisplay = empCode + " - " + name;
            parentForm.LoadAdvanceData(empDisplay, advDate, amount, note, id); // পুরো EMP001 - নাম সহ পাঠানো হচ্ছে
            this.Close();
        }
    }
}

