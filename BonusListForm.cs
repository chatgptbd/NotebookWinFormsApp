using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class BonusListForm : Form
    {
        private readonly BonusEntryForm BonusEntryRef;
        string connectionString = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "notebook.db;Version=3;";

        public BonusListForm(BonusEntryForm bonusEntryForm)
        {
            InitializeComponent();
            BonusEntryRef = bonusEntryForm;
            LoadBonusList();
        }

        private void LoadBonusList()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("SlNo", "ID"); // সিরিয়াল নম্বর
            dataGridView1.Columns.Add("BonusId", "BonusId"); // হিডেন
            dataGridView1.Columns["BonusId"].Visible = false;

            dataGridView1.Columns.Add("BonusDate", "Bonus Date");
            dataGridView1.Columns.Add("BonusPercent", "Bonus %");
            dataGridView1.Columns.Add("Note", "Note");
            dataGridView1.Rows.Clear();

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT DISTINCT BonusId, BonusDate, BonusPercent, Note FROM Bonus ORDER BY BonusDate DESC";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                int sl = 1;
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        sl++,
                        reader["BonusId"].ToString(),
                        Convert.ToDateTime(reader["BonusDate"]).ToString("yyyy-MM-dd"),
                        reader["BonusPercent"].ToString(),
                        reader["Note"].ToString()
                    );
                }
            }
        }

        private void txtSearchNote_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearchNote.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = row.Cells["Note"].Value.ToString().ToLower().Contains(search);
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {
                e.Handled = true; // এন্টার প্রেসের ডিফল্ট বিহেভিয়ার বন্ধ
                int rowIndex = dataGridView1.CurrentRow.Index;

                string bonusId = dataGridView1.Rows[rowIndex].Cells["BonusId"].Value.ToString();
                string bonusDate = dataGridView1.Rows[rowIndex].Cells["BonusDate"].Value.ToString();
                string bonusPercent = dataGridView1.Rows[rowIndex].Cells["BonusPercent"].Value.ToString();
                string note = dataGridView1.Rows[rowIndex].Cells["Note"].Value.ToString();

                BonusEntryRef?.LoadBonusData(bonusId, bonusDate, bonusPercent, note);
                this.Close();
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string bonusId = dataGridView1.Rows[e.RowIndex].Cells["BonusId"].Value.ToString();
                string bonusDate = dataGridView1.Rows[e.RowIndex].Cells["BonusDate"].Value.ToString();
                string bonusPercent = dataGridView1.Rows[e.RowIndex].Cells["BonusPercent"].Value.ToString();
                string note = dataGridView1.Rows[e.RowIndex].Cells["Note"].Value.ToString();

                BonusEntryRef?.LoadBonusData(bonusId, bonusDate, bonusPercent, note);
                this.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
