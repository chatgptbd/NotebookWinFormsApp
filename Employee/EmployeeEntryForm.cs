using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class EmployeeEntryForm : Form
    {
        private EmployeeListForm listForm; // একাধিক ফর্ম খোলা রোধ করতে private string imagePath = "";

        private string imagePath = ""; // ছবির পাথ সংরক্ষণ করতে  

        public EmployeeEntryForm()
        {
            InitializeComponent();
            this.Load += EmployeeEntryForm_Load;
        }

        private void EmployeeEntryForm_Load(object sender, EventArgs e)
        {
            if (cmbMaritalStatus.Items.Count == 0)
                cmbMaritalStatus.Items.AddRange(new string[] { "Single", "Married", "Divorced", "Widowed" });

            if (cmbGender.Items.Count == 0)
                cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });

            txtEmpCode.Text = GenerateNewEmployeeCode();
            txtName.Focus();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (listForm == null || listForm.IsDisposed)
            {
                listForm = new EmployeeListForm();
                listForm.FormClosed += (s, args) => listForm = null; // ফর্ম বন্ধ হলে রেফারেন্স null করা
                listForm.Show();
            }
            else
            {
                listForm.BringToFront();
                listForm.Focus();
               

            }
        }

        private string GenerateNewEmployeeCode()
        {
            string newCode = "EMP001";
            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = "SELECT MAX(EmpCode) FROM Employee";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar()?.ToString();
                    if (!string.IsNullOrEmpty(result))
                    {
                        int num = int.Parse(result.Substring(3)) + 1;
                        newCode = "EMP" + num.ToString("D3");
                    }
                }
            }
            return newCode;
        }

        private void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb && tb.Name != "txtEmpCode")
                    tb.Text = "";
            }
            cmbGender.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
            dtpDob.Value = DateTime.Today;
            dtpJoinDate.Value = DateTime.Today;
            picPhoto.Image = null;
            imagePath = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtEmpCode.Text = GenerateNewEmployeeCode();
            txtName.Focus();
        }

        private bool IsEmployeeExists(string empCode)
        {
            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Employee WHERE EmpCode = @EmpCode";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpCode", empCode);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmpCode.Text) && IsEmployeeExists(txtEmpCode.Text))
            {
                MessageBox.Show("এই এমপ্লয়ি কোড এর ডাটা ইতিমধ্যে আছে। Update বাটন ব্যবহার করুন।", "সতর্কতা", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtMobileNo.Text))
            {
                MessageBox.Show("নাম এবং মোবাইল বাধ্যতামূলক", "ত্রুটি", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] photoBytes = null;
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                photoBytes = File.ReadAllBytes(imagePath);

            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = @"INSERT INTO Employee (EmpCode, Name, FatherName, MotherName, MobileNo, EmergencyContact, NationalId,
                    DateOfBirth, MaritalStatus, Gender, JoinDate, InitialSalary, PresentAddress, PermanentAddress,
                    Note, Photo, CreatedAt)
                 VALUES (@EmpCode, @Name, @FatherName, @MotherName, @MobileNo, @EmergencyContact, @NationalId,
                    @DateOfBirth, @MaritalStatus, @Gender, @JoinDate, @InitialSalary, @PresentAddress,
                    @PermanentAddress, @Note, @Photo, datetime('now'))";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpCode", txtEmpCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text.Trim());
                    cmd.Parameters.AddWithValue("@MotherName", txtMotherName.Text.Trim());
                    cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmergencyContact", txtEmergencyContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@NationalId", txtNationalId.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDob.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@MaritalStatus", cmbMaritalStatus.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@InitialSalary", txtInitialSalary.Text.Trim());
                    cmd.Parameters.AddWithValue("@PresentAddress", txtPresentAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@PermanentAddress", txtPermanentAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());
                    cmd.Parameters.AddWithValue("@Photo", photoBytes ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("তথ্য সফলভাবে সংরক্ষণ হয়েছে", "সফল", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            txtEmpCode.Text = GenerateNewEmployeeCode();
            txtName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpCode.Text))
            {
                MessageBox.Show("অনুগ্রহ করে একটি এমপ্লয়ি কোড দিন!");
                return;
            }

            byte[] photoBytes = null;

            if (picPhoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (Bitmap bmp = new Bitmap(picPhoto.Image))
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        photoBytes = ms.ToArray();
                    }
                }
            }

            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = @"UPDATE Employee SET 
                        Name = @Name,
                        FatherName = @FatherName,
                        MotherName = @MotherName,
                        MobileNo = @MobileNo,
                        EmergencyContact = @EmergencyContact,
                        NationalId = @NationalId,
                        DateOfBirth = @DateOfBirth,
                        JoinDate = @JoinDate,
                        MaritalStatus = @MaritalStatus,
                        Gender = @Gender,
                        InitialSalary = @InitialSalary,
                        PresentAddress = @PresentAddress,
                        PermanentAddress = @PermanentAddress,
                        Note = @Note,
                        Photo = @Photo
                     WHERE EmpCode = @EmpCode";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    cmd.Parameters.AddWithValue("@MotherName", txtMotherName.Text);
                    cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@EmergencyContact", txtEmergencyContact.Text);
                    cmd.Parameters.AddWithValue("@NationalId", txtNationalId.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDob.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@MaritalStatus", cmbMaritalStatus.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@InitialSalary", txtInitialSalary.Text);
                    cmd.Parameters.AddWithValue("@PresentAddress", txtPresentAddress.Text);
                    cmd.Parameters.AddWithValue("@PermanentAddress", txtPermanentAddress.Text);
                    cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                    cmd.Parameters.AddWithValue("@Photo", photoBytes ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@EmpCode", txtEmpCode.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("তথ্য সফলভাবে আপডেট হয়েছে", "সফল", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // আপডেট শেষে ফর্ম ক্লিয়ার ও নতুন কোড সেট
            ClearForm();
            txtEmpCode.Text = GenerateNewEmployeeCode();
            txtName.Focus();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpCode.Text))
            {
                MessageBox.Show("একটি এমপ্লয়ি কোড দিন", "ত্রুটি", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("আপনি কি নিশ্চিতভাবে এই তথ্য মুছতে চান?", "নিশ্চিতকরণ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection("Data Source=notebook.db"))
                {
                    conn.Open();
                    string query = "DELETE FROM Employee WHERE EmpCode = @EmpCode";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpCode", txtEmpCode.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("তথ্য সফলভাবে মুছে ফেলা হয়েছে", "সফল", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            txtEmpCode.Text = GenerateNewEmployeeCode();
                            txtName.Focus();
                        }
                        else
                        {
                            MessageBox.Show("এই কোডে কোন তথ্য খুঁজে পাওয়া যায়নি", "ত্রুটি", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    picPhoto.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            picPhoto.Image = null;
            imagePath = "";
        }
        private void ClearForm()
        {
            txtEmpCode.Clear();
            txtName.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
            txtMobileNo.Clear();
            txtEmergencyContact.Clear();
            txtNationalId.Clear();
            txtInitialSalary.Clear();
            txtNote.Clear();
            txtPresentAddress.Clear();
            txtPermanentAddress.Clear();
            cmbGender.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
            dtpDob.Value = DateTime.Today;
            dtpJoinDate.Value = DateTime.Today;
            picPhoto.Image = null;
        }

        public void LoadEmployeeFromList(string empCode)
        {
            using (var conn = new SQLiteConnection("Data Source=notebook.db"))
            {
                conn.Open();
                string query = "SELECT * FROM Employee WHERE EmpCode = @EmpCode";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpCode", empCode);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtEmpCode.Text = reader["EmpCode"].ToString();
                            txtName.Text = reader["Name"].ToString();
                            txtFatherName.Text = reader["FatherName"].ToString();
                            txtMotherName.Text = reader["MotherName"].ToString();
                            txtMobileNo.Text = reader["MobileNo"].ToString();
                            txtEmergencyContact.Text = reader["EmergencyContact"].ToString();
                            txtNationalId.Text = reader["NationalId"].ToString();
                            dtpDob.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                            cmbMaritalStatus.Text = reader["MaritalStatus"].ToString();
                            cmbGender.Text = reader["Gender"].ToString();
                            dtpJoinDate.Value = Convert.ToDateTime(reader["JoinDate"]);
                            txtInitialSalary.Text = reader["InitialSalary"].ToString();
                            txtPresentAddress.Text = reader["PresentAddress"].ToString();
                            txtPermanentAddress.Text = reader["PermanentAddress"].ToString();
                            txtNote.Text = reader["Note"].ToString();
                            if (!(reader["Photo"] is DBNull))
                            {
                                byte[] photoBytes = (byte[])reader["Photo"];
                                using (var ms = new MemoryStream(photoBytes))
                                {
                                    picPhoto.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                picPhoto.Image = null;
                            }

                            // ফোকাস এবং কার্সর নামের শেষে সেট
                            txtName.Focus();
                            txtName.SelectionStart = txtName.Text.Length;
                        }
                    }
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}