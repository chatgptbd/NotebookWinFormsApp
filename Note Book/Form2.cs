using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;

namespace NotebookSQLiteApp
{
    public partial class Form2 : Form
    {
        private readonly Form1 mainForm;
        private readonly string dbPath = "Notebook.db";
        private readonly string connStr = $"Data Source=Notebook.db;Version=3;";
        private DataTable fullData = new DataTable();

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            SetupDataGridView();
            SetupEvents();

            LoadData();
            txtSearchModel.Focus();
        }

        private void SetupDataGridView()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void SetupEvents()
        {
            txtSearchModel.KeyDown += TxtSearchModel_KeyDown;
            txtSearchReverseNo.KeyDown += TxtSearchModel_KeyDown;
            txtSearchDescription.KeyDown += TxtSearchModel_KeyDown;

            txtSearchModel.TextChanged += (s, e) => FilterData();
            txtSearchReverseNo.TextChanged += (s, e) => FilterData();
            txtSearchDescription.TextChanged += (s, e) => FilterData();

            dataGridView1.KeyDown += DataGridView1_KeyDown;
        }

        private void LoadData()
        {
            using var conn = new SQLiteConnection(connStr);
            conn.Open();
            var adapter = new SQLiteDataAdapter("SELECT Model, ReverseNo, Description FROM Notebook", conn);
            fullData.Clear();
            adapter.Fill(fullData);

            DisplayData(fullData); // ডাটা শো করার জন্য

            // Step 1: প্রথমে AutoSize বন্ধ করবেন
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Step 2: এরপর নিজের মতো করে ম্যানুয়ালি কলামের Width ঠিক করবেন
            if (dataGridView1.Columns.Contains("SL"))
                dataGridView1.Columns["SL"].Width = 50;
            if (dataGridView1.Columns.Contains("Model"))
                dataGridView1.Columns["Model"].Width = 200;
            if (dataGridView1.Columns.Contains("ReverseNo"))
                dataGridView1.Columns["ReverseNo"].Width = 200;
            if (dataGridView1.Columns.Contains("Description"))
                dataGridView1.Columns["Description"].Width = 200;

            // Step 3: প্রথম Row সিলেক্ট করে দিবে যদি Row থাকে
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
            }

            // Step 4: Row Count আপডেট
            lblRowCount.Text = $"Total Rows: {dataGridView1.Rows.Count}";
        }

        private void DisplayData(DataTable source)
        {
            DataTable displayTable = new DataTable();
            displayTable.Columns.Add("SL", typeof(int));
            displayTable.Columns.Add("Model");
            displayTable.Columns.Add("ReverseNo");
            displayTable.Columns.Add("Description");

            int sl = 1;
            foreach (DataRow row in source.Rows)
            {
                displayTable.Rows.Add(sl++, row["Model"], row["ReverseNo"], row["Description"]);
            }

            dataGridView1.DataSource = displayTable;

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows[0].Selected = true;

            lblRowCount.Text = $"Total Rows: {displayTable.Rows.Count}";
        }

        private void FilterData()
        {
            string model = txtSearchModel.Text.Trim().ToLower();
            string reverse = txtSearchReverseNo.Text.Trim().ToLower();
            string description = txtSearchDescription.Text.Trim().ToLower();

            var filtered = fullData.AsEnumerable()
                .Where(row =>
                    row["Model"].ToString().ToLower().Contains(model) &&
                    row["ReverseNo"].ToString().ToLower().Contains(reverse) &&
                    row["Description"].ToString().ToLower().Contains(description));

            if (filtered.Any())
                DisplayData(filtered.CopyToDataTable());
            else
                dataGridView1.DataSource = null;
        }

        private void TxtSearchModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.Rows.Count > 0)
            {
                SendSelectedDataToForm1();
            }
            else if (e.KeyCode == Keys.Down && dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Focus();
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendSelectedDataToForm1();
            }
        }

        private void SendSelectedDataToForm1()
        {
            if (dataGridView1.CurrentRow != null)
            {
                string model = dataGridView1.CurrentRow.Cells["Model"].Value?.ToString();
                string reverse = dataGridView1.CurrentRow.Cells["ReverseNo"].Value?.ToString();
                string description = dataGridView1.CurrentRow.Cells["Description"].Value?.ToString();

                mainForm.SetDataFromForm2("", model, reverse, description);
                this.Close();
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using var package = new ExcelPackage();
                var ws = package.Workbook.Worksheets.Add("Notebook");

                var dt = (DataTable)dataGridView1.DataSource;
                for (int col = 0; col < dt.Columns.Count; col++)
                    ws.Cells[1, col + 1].Value = dt.Columns[col].ColumnName;

                for (int row = 0; row < dt.Rows.Count; row++)
                    for (int col = 0; col < dt.Columns.Count; col++)
                        ws.Cells[row + 2, col + 1].Value = dt.Rows[row][col];

                File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                MessageBox.Show("Exported successfully!");
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Files|*.xlsx" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using var package = new ExcelPackage(new FileInfo(ofd.FileName));
                var ws = package.Workbook.Worksheets[0];
                int rowCount = ws.Dimension.Rows;

                using var conn = new SQLiteConnection(connStr);
                conn.Open();
                using var tran = conn.BeginTransaction();

                for (int row = 2; row <= rowCount; row++)
                {
                    string model = ws.Cells[row, 2].Text;
                    string reverse = ws.Cells[row, 3].Text;
                    string desc = ws.Cells[row, 4].Text;

                    var cmd = new SQLiteCommand("INSERT INTO Notebook (Model, ReverseNo, Description) VALUES (@m,@r,@d)", conn, tran);
                    cmd.Parameters.AddWithValue("@m", model);
                    cmd.Parameters.AddWithValue("@r", reverse);
                    cmd.Parameters.AddWithValue("@d", desc);
                    cmd.ExecuteNonQuery();
                }

                tran.Commit();
                LoadData();
                MessageBox.Show("Imported successfully!");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all data?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var conn = new SQLiteConnection(connStr);
                conn.Open();
                new SQLiteCommand("DELETE FROM Notebook", conn).ExecuteNonQuery();
                new SQLiteCommand("DELETE FROM sqlite_sequence WHERE name='Notebook'", conn).ExecuteNonQuery();
                LoadData();
            }
        }

        private void btnBackupDB_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog { Filter = "SQLite Database|*.db" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string source = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbPath);
                File.Copy(source, sfd.FileName, true);
                MessageBox.Show("Backup completed!");
            }
        }
    }
}
