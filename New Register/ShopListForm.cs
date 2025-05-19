using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NotebookWinFormsApp
{
    public partial class ShopListForm : Form
    {
        private NewRegisterShopForm parentForm;
        private DataTable shopTable;

        public ShopListForm(NewRegisterShopForm form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void ShopListForm_Load(object sender, EventArgs e)
        {
            cmbSearchBy.Items.AddRange(new string[] { "ShopName", "OwnerName", "Mobile" });
            cmbSearchBy.SelectedIndex = 0;
            LoadShopList();
        }

        private void LoadShopList()
        {
            string connectionString = "Data Source=Notebook.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Shops ORDER BY ShopName";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        shopTable = new DataTable();
                        da.Fill(shopTable);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = shopTable;
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (shopTable == null || cmbSearchBy.SelectedItem == null) return;

            string column = cmbSearchBy.SelectedItem.ToString();
            string search = txtSearch.Text.Replace("'", "''");

            shopTable.DefaultView.RowFilter = $"{column} LIKE '%{search}%'";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedCode = dataGridView1.Rows[e.RowIndex].Cells["ShopCode"].Value.ToString();
                parentForm.SelectedShopCode = selectedCode;
            }
        }

        private void dataGridViw1_KeyDown(object sender, KeyEventArgs e)
        {
                    
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {
                e.Handled = true; // Enter key ডিফল্ট একশন বন্ধ
                string selectedCode = dataGridView1.CurrentRow.Cells["ShopCode"].Value.ToString();
                parentForm.SelectedShopCode = selectedCode;
                this.Close();
            }
        }

    }
    
}
