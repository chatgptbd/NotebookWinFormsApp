using System; // 1
using System.Data.SQLite; // 2
using System.Drawing; // 3
using System.IO; // 4
using System.Windows.Forms; // 5
                            // 6
namespace NotebookWinFormsApp // 7
{ // 8
    public partial class EmployeeEntryForm : Form // 9
    { // 10

        public TextBox TxtShopName => txtShopName; 
        public TextBox TxtShopCode => txtShopCode;
        public TextBox TxtShopAddress => txtShopAddress;


        private EmployeeListForm listForm;
                                           
        private string imagePath = ""; 
                                     
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
                listForm.FormClosed += (s, args) => listForm = null; // ফর্ম বন্ধ হলে রেফারেন্স null করা // 38
                listForm.Show(); // 39
            } // 40
            else // 41
            { // 42
                listForm.BringToFront(); // 43
                listForm.Focus(); // 44
                                  // 45
                                  // 46
            } // 47
        } // 48
          // 49
        private string GenerateNewEmployeeCode() // 50
        { // 51
            string newCode = "EMP001"; // 52
            using (var conn = new SQLiteConnection("Data Source=notebook.db")) // 53
            { // 54
                conn.Open(); // 55
                string query = "SELECT MAX(EmpCode) FROM Employee"; // 56
                using (var cmd = new SQLiteCommand(query, conn)) // 57
                { // 58
                    var result = cmd.ExecuteScalar()?.ToString(); // 59
                    if (!string.IsNullOrEmpty(result)) // 60
                    { // 61
                        int num = int.Parse(result.Substring(3)) + 1; // 62
                        newCode = "EMP" + num.ToString("D3"); // 63
                    } // 64
                } // 65
            } // 66
            return newCode; // 67
        } // 68
          // 69
        private void ClearFields() // 70
        { // 71
            foreach (Control c in this.Controls) // 72
            { // 73
                if (c is TextBox tb && tb.Name != "txtEmpCode") // 74
                    tb.Text = ""; // 75
            } // 76
            cmbGender.SelectedIndex = -1; // 77
            cmbMaritalStatus.SelectedIndex = -1; // 78
            dtpDob.Value = DateTime.Today; // 79
            dtpJoinDate.Value = DateTime.Today; // 80
            picPhoto.Image = null; // 81
            imagePath = ""; // 82
        } // 83
          // 84
        private void btnNew_Click(object sender, EventArgs e) // 85
        { // 86
            ClearFields(); // 87
            txtEmpCode.Text = GenerateNewEmployeeCode(); // 88
            txtName.Focus(); // 89
        } // 90
          // 91
        private bool IsEmployeeExists(string empCode) // 92
        { // 93
            using (var conn = new SQLiteConnection("Data Source=notebook.db")) // 94
            { // 95
                conn.Open(); // 96
                string query = "SELECT COUNT(*) FROM Employee WHERE EmpCode = @EmpCode"; // 97
                using (var cmd = new SQLiteCommand(query, conn)) // 98
                { // 99
                    cmd.Parameters.AddWithValue("@EmpCode", empCode); // 100
                    int count = Convert.ToInt32(cmd.ExecuteScalar()); // 101
                    return count > 0; // 102
                } // 103
            } // 104
        } // 105
          // 106
        private void btnSave_Click(object sender, EventArgs e) // 107
        { // 108
            if (!string.IsNullOrEmpty(txtEmpCode.Text) && IsEmployeeExists(txtEmpCode.Text)) // 109
            { // 110
                MessageBox.Show("এই এমপ্লয়ি কোড এর ডাটা ইতিমধ্যে আছে। Update বাটন ব্যবহার করুন।", "সতর্কতা", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 111
                return; // 112
            } // 113

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtMobileNo.Text)) // 115
            { // 116
                MessageBox.Show("নাম এবং মোবাইল বাধ্যতামূলক", "ত্রুটি", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 117
                return; // 118
            } // 119

            byte[] photoBytes = null; // 121
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath)) // 122
                photoBytes = File.ReadAllBytes(imagePath); // 123

            using (var conn = new SQLiteConnection("Data Source=notebook.db")) // 125
            { // 126
                conn.Open(); // 127
                string query = @"INSERT INTO Employee 
            (EmpCode, Name, FatherName, MotherName, MobileNo, EmergencyContact, NationalId, 
             DateOfBirth, MaritalStatus, Gender, JoinDate, InitialSalary, PresentAddress, PermanentAddress, 
             Note, Photo, ShopCode, ShopName, ShopAddress, CreatedAt) 
             VALUES 
            (@EmpCode, @Name, @FatherName, @MotherName, @MobileNo, @EmergencyContact, @NationalId, 
             @DateOfBirth, @MaritalStatus, @Gender, @JoinDate, @InitialSalary, @PresentAddress, @PermanentAddress, 
             @Note, @Photo, @ShopCode, @ShopName, @ShopAddress, datetime('now'))"; // 133

                using (var cmd = new SQLiteCommand(query, conn)) // 135
                { // 136
                    cmd.Parameters.AddWithValue("@EmpCode", txtEmpCode.Text.Trim()); // 137
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim()); // 138
                    cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text.Trim()); // 139
                    cmd.Parameters.AddWithValue("@MotherName", txtMotherName.Text.Trim()); // 140
                    cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text.Trim()); // 141
                    cmd.Parameters.AddWithValue("@EmergencyContact", txtEmergencyContact.Text.Trim()); // 142
                    cmd.Parameters.AddWithValue("@NationalId", txtNationalId.Text.Trim()); // 143
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDob.Value.ToString("yyyy-MM-dd")); // 144
                    cmd.Parameters.AddWithValue("@MaritalStatus", cmbMaritalStatus.Text); // 145
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text); // 146
                    cmd.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value.ToString("yyyy-MM-dd")); // 147
                    cmd.Parameters.AddWithValue("@InitialSalary", txtInitialSalary.Text.Trim()); // 148
                    cmd.Parameters.AddWithValue("@PresentAddress", txtPresentAddress.Text.Trim()); // 149
                    cmd.Parameters.AddWithValue("@PermanentAddress", txtPermanentAddress.Text.Trim()); // 150
                    cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim()); // 151
                    cmd.Parameters.AddWithValue("@Photo", photoBytes ?? (object)DBNull.Value); // 152
                    cmd.Parameters.AddWithValue("@ShopCode", txtShopCode.Text.Trim()); // 153
                    cmd.Parameters.AddWithValue("@ShopName", txtShopName.Text.Trim()); // 154
                    cmd.Parameters.AddWithValue("@ShopAddress", txtShopAddress.Text.Trim()); // 155
                    cmd.ExecuteNonQuery(); // 156
                } // 157
            } // 158

            MessageBox.Show("তথ্য সফলভাবে সংরক্ষণ হয়েছে", "সফল", MessageBoxButtons.OK, MessageBoxIcon.Information); // 159
            ClearFields(); // 160
            txtEmpCode.Text = GenerateNewEmployeeCode(); // 161
            txtName.Focus(); // 162
        } // 163


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
                Photo = @Photo,
                ShopCode = @ShopCode,
                ShopName = @ShopName,
                ShopAddress = @ShopAddress
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
                    cmd.Parameters.AddWithValue("@ShopCode", txtShopCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@ShopName", txtShopName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ShopAddress", txtShopAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmpCode", txtEmpCode.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("তথ্য সফলভাবে আপডেট হয়েছে", "সফল", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearForm();
            txtEmpCode.Text = GenerateNewEmployeeCode();
            txtName.Focus();
        }
        private void btnDelete_Click(object sender, EventArgs e) // 238
        { // 239
            if (string.IsNullOrWhiteSpace(txtEmpCode.Text)) // 240
            { // 241
                MessageBox.Show("একটি এমপ্লয়ি কোড দিন", "ত্রুটি", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 242
                return; // 243
            } // 244
              // 245
            DialogResult result = MessageBox.Show("আপনি কি নিশ্চিতভাবে এই তথ্য মুছতে চান?", "নিশ্চিতকরণ", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // 246
            if (result == DialogResult.Yes) // 247
            { // 248
                using (var conn = new SQLiteConnection("Data Source=notebook.db")) // 249
                { // 250
                    conn.Open(); // 251
                    string query = "DELETE FROM Employee WHERE EmpCode = @EmpCode"; // 252
                    using (var cmd = new SQLiteCommand(query, conn)) // 253
                    { // 254
                        cmd.Parameters.AddWithValue("@EmpCode", txtEmpCode.Text.Trim()); // 255
                        int rowsAffected = cmd.ExecuteNonQuery(); // 256
                        if (rowsAffected > 0) // 257
                        { // 258
                            MessageBox.Show("তথ্য সফলভাবে মুছে ফেলা হয়েছে", "সফল", MessageBoxButtons.OK, MessageBoxIcon.Information); // 259
                            ClearFields(); // 260
                            txtEmpCode.Text = GenerateNewEmployeeCode(); // 261
                            txtName.Focus(); // 262
                        } // 263
                        else // 264
                        { // 265
                            MessageBox.Show("এই কোডে কোন তথ্য খুঁজে পাওয়া যায়নি", "ত্রুটি", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 266
                        } // 267
                    } // 268
                } // 269
            } // 270
        } // 271
          // 272
        private void btnBrowse_Click(object sender, EventArgs e) // 273
        { // 274
            using (OpenFileDialog ofd = new OpenFileDialog()) // 275
            { // 276
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"; // 277
                if (ofd.ShowDialog() == DialogResult.OK) // 278
                { // 279
                    imagePath = ofd.FileName; // 280
                    picPhoto.Image = Image.FromFile(imagePath); // 281
                } // 282
            } // 283
        } // 284
          // 285
        private void btnRemove_Click(object sender, EventArgs e) // 286
        { // 287
            picPhoto.Image = null; // 288
            imagePath = ""; // 289
        } // 290
        private void ClearForm() // 291
        { // 292
            txtEmpCode.Clear(); // 293
            txtName.Clear(); // 294
            txtFatherName.Clear(); // 295
            txtMotherName.Clear(); // 296
            txtMobileNo.Clear(); // 297
            txtEmergencyContact.Clear(); // 298
            txtNationalId.Clear(); // 299
            txtInitialSalary.Clear(); // 300
            txtNote.Clear(); // 301
            txtPresentAddress.Clear(); // 302
            txtPermanentAddress.Clear(); // 303
            cmbGender.SelectedIndex = -1; // 304
            cmbMaritalStatus.SelectedIndex = -1; // 305
            dtpDob.Value = DateTime.Today; // 306
            dtpJoinDate.Value = DateTime.Today; // 307
            picPhoto.Image = null;
            txtShopCode.Clear();
            txtShopName.Clear();
            txtShopAddress.Clear();
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

                            // নতুন যোগ করা Shop ফিল্ড লোড
                            txtShopCode.Text = reader["ShopCode"].ToString();
                            txtShopName.Text = reader["ShopName"].ToString();
                            txtShopAddress.Text = reader["ShopAddress"].ToString();

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


        private void btnF1_Click(object sender, EventArgs e)
        {
            using (ShopAccessForm accessForm = new ShopAccessForm())
            {
                if (accessForm.ShowDialog() == DialogResult.OK)
                {
                    using (ShopListForm listForm = new ShopListForm(this))
                    {
                        listForm.ShowDialog();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) // 360
        { // 361
            this.Close(); // 362
        } // 363
    } // 364
      // 365
} // 366
