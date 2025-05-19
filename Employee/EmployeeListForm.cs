// Final fixed version for EmployeeListForm.cs
using System; 
using System.Data.SQLite; 
using System.Drawing; 
using System.IO; 
using System.Windows.Forms;



namespace NotebookWinFormsApp
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm() { InitializeComponent(); this.Load += EmployeeListForm_Load; txtSearchName.TextChanged += Search_TextChanged; txtSearchMobileNo.TextChanged += Search_TextChanged; dataGridView1.SelectionChanged += DataGridView1_SelectionChanged; dataGridView1.KeyDown += DataGridView1_KeyDown; txtSearchName.KeyDown += TxtSearchName_KeyDown; txtSearchMobileNo.KeyDown += TxtSearchName_KeyDown; }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            txtSearchName.Focus();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = @"SELECT EmpCode, Name, MobileNo, JoinDate, InitialSalary, MaritalStatus, Gender,
                             PresentAddress, PermanentAddress, Photo FROM Employee
                             WHERE Name LIKE @Name AND MobileNo LIKE @Mobile";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", "%" + txtSearchName.Text + "%");
                    cmd.Parameters.AddWithValue("@Mobile", "%" + txtSearchMobileNo.Text + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        int serial = 1;
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(serial++,
                                reader["EmpCode"],
                                reader["Name"],
                                reader["MobileNo"],
                                Convert.ToDateTime(reader["JoinDate"]).ToString("dd-MM-yyyy"),
                                reader["InitialSalary"],
                                reader["MaritalStatus"],
                                reader["Gender"]);

                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Tag = new
                            {
                                Present = reader["PresentAddress"].ToString(),
                                Permanent = reader["PermanentAddress"].ToString(),
                                Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"]
                            };
                        }
                    }
                }
            }

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows[0].Selected = true;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.Tag is not null)
            {
                var tag = (dynamic)dataGridView1.CurrentRow.Tag;

                txtPresentAddress.Text = tag.Present;
                txtPermanentAddress.Text = tag.Permanent;

                if (tag.Photo != null)
                {
                    using var ms = new MemoryStream(tag.Photo);
                    picPhoto.Image = Image.FromStream(ms);
                }
                else
                {
                    picPhoto.Image = null;
                }
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {
                e.Handled = true;
                string empCode = dataGridView1.CurrentRow.Cells["ColEmpCode"].Value.ToString();
                if (Application.OpenForms["EmployeeEntryForm"] is EmployeeEntryForm entryForm)
                {
                    entryForm.LoadEmployeeFromList(empCode);
                    entryForm.BringToFront();
                    this.Close();
                }
            }
        }

        private void TxtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.Rows.Count > 0)
            {
                e.Handled = true;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.Focus();
            }
        }
    }

}