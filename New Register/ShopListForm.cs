using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class ShopListForm : Form
    {
        private Form parentForm;

        public ShopListForm(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void ShopListForm_Load(object sender, EventArgs e)
        {
            LoadShopList();
        }

        private void LoadShopList()
        {
            string connectionString = "Data Source=Notebook.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Shops ORDER BY Id DESC";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {
                e.Handled = true;

                string selectedCode = dataGridView1.CurrentRow.Cells["ShopCode"].Value.ToString();
                string selectedName = dataGridView1.CurrentRow.Cells["ShopName"].Value.ToString();
                string selectedOwner = dataGridView1.CurrentRow.Cells["OwnerName"].Value.ToString();
                string selectedMobile = dataGridView1.CurrentRow.Cells["Mobile"].Value.ToString();
                string selectedAddress = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
                string selectedEmail = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                string selectedType = dataGridView1.CurrentRow.Cells["ShopType"].Value.ToString();
                string selectedDate = dataGridView1.CurrentRow.Cells["OpeningDate"].Value.ToString();
                string selectedLicense = dataGridView1.CurrentRow.Cells["LicenseNo"].Value.ToString();
                string selectedStatus = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();

                DialogResult confirm = MessageBox.Show("আপনি কি এই শপটি সিলেক্ট করতে চান?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                if (parentForm is NewRegisterShopForm newForm)
                {
                    newForm.TxtShopCode.Text = selectedCode;
                    newForm.TxtShopName.Text = selectedName;
                    newForm.TxtOwnerName.Text = selectedOwner;
                    newForm.TxtMobile.Text = selectedMobile;
                    newForm.TxtAddress.Text = selectedAddress;
                    newForm.TxtEmail.Text = selectedEmail;
                    newForm.CmbShopType.Text = selectedType;
                    newForm.DtpOpeningDate.Value = DateTime.Parse(selectedDate);
                    newForm.TxtLicenseNo.Text = selectedLicense;
                    newForm.CmbStatus.Text = selectedStatus;
                }
                else if (parentForm is EmployeeEntryForm empForm)
                {
                    empForm.TxtShopCode.Text = selectedCode;
                    empForm.TxtShopName.Text = selectedName;
                    empForm.TxtShopAddress.Text = selectedAddress;
                }

                this.Close();
            }
        }
    }

}
