﻿namespace NotebookWinFormsApp // 1
{ // 2
    partial class EmployeeEntryForm // 3
    { // 4
        /// <summary> // 5
        /// Required designer variable. // 6
        /// </summary> // 7
        private System.ComponentModel.IContainer components = null; // 8
                                                                    // 9
        /// <summary> // 10
        /// Clean up any resources being used. // 11
        /// </summary> // 12
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> // 13
        protected override void Dispose(bool disposing) // 14
        { // 15
            if (disposing && (components != null)) // 16
            { // 17
                components.Dispose(); // 18
            } // 19
            base.Dispose(disposing); // 20
        } // 21
          // 22
        #region Windows Form Designer generated code // 23
        // 24
        /// <summary> // 25
        /// Required method for Designer support - do not modify // 26
        /// the contents of this method with the code editor. // 27
        /// </summary> // 28
        private void InitializeComponent() // 29
        { // 30
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            txtEmpCode = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtFatherName = new System.Windows.Forms.TextBox();
            txtMotherName = new System.Windows.Forms.TextBox();
            txtMobileNo = new System.Windows.Forms.TextBox();
            txtEmergencyContact = new System.Windows.Forms.TextBox();
            txtNationalId = new System.Windows.Forms.TextBox();
            dtpDob = new System.Windows.Forms.DateTimePicker();
            cmbGender = new System.Windows.Forms.ComboBox();
            cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            txtPresentAddress = new System.Windows.Forms.TextBox();
            txtPermanentAddress = new System.Windows.Forms.TextBox();
            dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            txtInitialSalary = new System.Windows.Forms.TextBox();
            picPhoto = new System.Windows.Forms.PictureBox();
            btnSelectImage = new System.Windows.Forms.Button();
            btnRemoveImage = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnGetData = new System.Windows.Forms.Button();
            btnUpDate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            txtNote = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            btnF1 = new System.Windows.Forms.Button();
            label16 = new System.Windows.Forms.Label();
            txtShopCode = new System.Windows.Forms.TextBox();
            txtShopName = new System.Windows.Forms.TextBox();
            txtShopAddress = new System.Windows.Forms.TextBox();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 21);
            label1.TabIndex = 0;
            label1.Text = "Employee Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(30, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(30, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 21);
            label3.TabIndex = 2;
            label3.Text = "Father Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(30, 123);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(107, 21);
            label4.TabIndex = 3;
            label4.Text = "Mother Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(30, 161);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 21);
            label5.TabIndex = 4;
            label5.Text = "Mobile No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(30, 202);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(140, 21);
            label6.TabIndex = 5;
            label6.Text = "EmergencyContact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(30, 237);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 21);
            label7.TabIndex = 6;
            label7.Text = "National ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(30, 274);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(100, 21);
            label8.TabIndex = 7;
            label8.Text = "Date Of Birth";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(308, 312);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(61, 21);
            label9.TabIndex = 8;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(308, 277);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(105, 21);
            label10.TabIndex = 9;
            label10.Text = "Marital Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(30, 385);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(122, 21);
            label11.TabIndex = 10;
            label11.Text = "Present Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(30, 458);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(145, 21);
            label12.TabIndex = 11;
            label12.Text = "Permanent Address";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(30, 311);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(74, 21);
            label13.TabIndex = 12;
            label13.Text = "Join Date";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(30, 348);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(95, 21);
            label14.TabIndex = 13;
            label14.Text = "Initial Salary";
            // 
            // txtEmpCode
            // 
            txtEmpCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmpCode.Location = new System.Drawing.Point(176, 15);
            txtEmpCode.Name = "txtEmpCode";
            txtEmpCode.Size = new System.Drawing.Size(146, 29);
            txtEmpCode.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(176, 50);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(362, 29);
            txtName.TabIndex = 0;
            // 
            // txtFatherName
            // 
            txtFatherName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFatherName.Location = new System.Drawing.Point(176, 85);
            txtFatherName.Name = "txtFatherName";
            txtFatherName.Size = new System.Drawing.Size(362, 29);
            txtFatherName.TabIndex = 1;
            // 
            // txtMotherName
            // 
            txtMotherName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMotherName.Location = new System.Drawing.Point(176, 123);
            txtMotherName.Name = "txtMotherName";
            txtMotherName.Size = new System.Drawing.Size(362, 29);
            txtMotherName.TabIndex = 2;
            // 
            // txtMobileNo
            // 
            txtMobileNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMobileNo.Location = new System.Drawing.Point(176, 161);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.Size = new System.Drawing.Size(362, 29);
            txtMobileNo.TabIndex = 3;
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmergencyContact.Location = new System.Drawing.Point(176, 199);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new System.Drawing.Size(362, 29);
            txtEmergencyContact.TabIndex = 4;
            // 
            // txtNationalId
            // 
            txtNationalId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNationalId.Location = new System.Drawing.Point(176, 237);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new System.Drawing.Size(362, 29);
            txtNationalId.TabIndex = 5;
            // 
            // dtpDob
            // 
            dtpDob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDob.Location = new System.Drawing.Point(178, 273);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new System.Drawing.Size(122, 29);
            dtpDob.TabIndex = 6;
            // 
            // cmbGender
            // 
            cmbGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new System.Drawing.Point(416, 309);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new System.Drawing.Size(122, 29);
            cmbGender.TabIndex = 8;
            // 
            // cmbMaritalStatus
            // 
            cmbMaritalStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbMaritalStatus.FormattingEnabled = true;
            cmbMaritalStatus.Location = new System.Drawing.Point(416, 274);
            cmbMaritalStatus.Name = "cmbMaritalStatus";
            cmbMaritalStatus.Size = new System.Drawing.Size(122, 29);
            cmbMaritalStatus.TabIndex = 7;
            // 
            // txtPresentAddress
            // 
            txtPresentAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPresentAddress.Location = new System.Drawing.Point(178, 381);
            txtPresentAddress.Multiline = true;
            txtPresentAddress.Name = "txtPresentAddress";
            txtPresentAddress.Size = new System.Drawing.Size(360, 67);
            txtPresentAddress.TabIndex = 11;
            // 
            // txtPermanentAddress
            // 
            txtPermanentAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPermanentAddress.Location = new System.Drawing.Point(178, 457);
            txtPermanentAddress.Multiline = true;
            txtPermanentAddress.Name = "txtPermanentAddress";
            txtPermanentAddress.Size = new System.Drawing.Size(360, 79);
            txtPermanentAddress.TabIndex = 12;
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpJoinDate.Location = new System.Drawing.Point(178, 308);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new System.Drawing.Size(122, 29);
            dtpJoinDate.TabIndex = 9;
            // 
            // txtInitialSalary
            // 
            txtInitialSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtInitialSalary.Location = new System.Drawing.Point(177, 343);
            txtInitialSalary.Name = "txtInitialSalary";
            txtInitialSalary.Size = new System.Drawing.Size(193, 29);
            txtInitialSalary.TabIndex = 10;
            // 
            // picPhoto
            // 
            picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picPhoto.Location = new System.Drawing.Point(558, 53);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new System.Drawing.Size(217, 136);
            picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPhoto.TabIndex = 29;
            picPhoto.TabStop = false;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSelectImage.Location = new System.Drawing.Point(574, 206);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new System.Drawing.Size(75, 29);
            btnSelectImage.TabIndex = 13;
            btnSelectImage.Text = "Browse";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnBrowse_Click;
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRemoveImage.Location = new System.Drawing.Point(681, 205);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new System.Drawing.Size(75, 29);
            btnRemoveImage.TabIndex = 14;
            btnRemoveImage.Text = "Remove";
            btnRemoveImage.UseVisualStyleBackColor = true;
            btnRemoveImage.Click += btnRemove_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNew.Location = new System.Drawing.Point(800, 52);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(99, 30);
            btnNew.TabIndex = 16;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(800, 85);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(99, 30);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnGetData
            // 
            btnGetData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGetData.Location = new System.Drawing.Point(800, 118);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new System.Drawing.Size(99, 30);
            btnGetData.TabIndex = 18;
            btnGetData.Text = "GetData";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // btnUpDate
            // 
            btnUpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpDate.Location = new System.Drawing.Point(800, 153);
            btnUpDate.Name = "btnUpDate";
            btnUpDate.Size = new System.Drawing.Size(99, 30);
            btnUpDate.TabIndex = 19;
            btnUpDate.Text = "UpDate";
            btnUpDate.UseVisualStyleBackColor = true;
            btnUpDate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(800, 188);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(99, 30);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(800, 222);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(99, 28);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            txtNote.Location = new System.Drawing.Point(554, 458);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new System.Drawing.Size(345, 78);
            txtNote.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Salmon;
            label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(561, 421);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(61, 32);
            label15.TabIndex = 39;
            label15.Text = "Note";
            // 
            // btnF1
            // 
            btnF1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnF1.Location = new System.Drawing.Point(681, 245);
            btnF1.Name = "btnF1";
            btnF1.Size = new System.Drawing.Size(75, 26);
            btnF1.TabIndex = 40;
            btnF1.Text = "F1";
            btnF1.UseVisualStyleBackColor = true;
            btnF1.Click += btnF1_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(819, 280);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(74, 21);
            label16.TabIndex = 41;
            label16.Text = "Shop List";
            // 
            // txtShopCode
            // 
            txtShopCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtShopCode.Location = new System.Drawing.Point(662, 277);
            txtShopCode.Name = "txtShopCode";
            txtShopCode.Size = new System.Drawing.Size(151, 29);
            txtShopCode.TabIndex = 42;
            // 
            // txtShopName
            // 
            txtShopName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtShopName.Location = new System.Drawing.Point(662, 312);
            txtShopName.Name = "txtShopName";
            txtShopName.Size = new System.Drawing.Size(231, 29);
            txtShopName.TabIndex = 43;
            // 
            // txtShopAddress
            // 
            txtShopAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtShopAddress.Location = new System.Drawing.Point(662, 351);
            txtShopAddress.Multiline = true;
            txtShopAddress.Name = "txtShopAddress";
            txtShopAddress.Size = new System.Drawing.Size(231, 55);
            txtShopAddress.TabIndex = 44;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(550, 283);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(86, 21);
            label17.TabIndex = 45;
            label17.Text = "Shop Code";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label18.Location = new System.Drawing.Point(550, 317);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(92, 21);
            label18.TabIndex = 46;
            label18.Text = "Shop Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label19.Location = new System.Drawing.Point(550, 366);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(106, 21);
            label19.TabIndex = 47;
            label19.Text = "Shop Address";
            // 
            // EmployeeEntryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(928, 595);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(txtShopAddress);
            Controls.Add(txtShopName);
            Controls.Add(txtShopCode);
            Controls.Add(label16);
            Controls.Add(btnF1);
            Controls.Add(label15);
            Controls.Add(txtNote);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpDate);
            Controls.Add(btnGetData);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(btnRemoveImage);
            Controls.Add(btnSelectImage);
            Controls.Add(picPhoto);
            Controls.Add(txtInitialSalary);
            Controls.Add(dtpJoinDate);
            Controls.Add(txtPermanentAddress);
            Controls.Add(txtPresentAddress);
            Controls.Add(cmbMaritalStatus);
            Controls.Add(cmbGender);
            Controls.Add(dtpDob);
            Controls.Add(txtNationalId);
            Controls.Add(txtEmergencyContact);
            Controls.Add(txtMobileNo);
            Controls.Add(txtMotherName);
            Controls.Add(txtFatherName);
            Controls.Add(txtName);
            Controls.Add(txtEmpCode);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeEntryForm";
            Text = "EmployeeEntryForm";
            Load += EmployeeEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        } // 553
          // 554
        #endregion // 555
        // 556
        private System.Windows.Forms.Label label1; // 557
        private System.Windows.Forms.Label label2; // 558
        private System.Windows.Forms.Label label3; // 559
        private System.Windows.Forms.Label label4; // 560
        private System.Windows.Forms.Label label5; // 561
        private System.Windows.Forms.Label label6; // 562
        private System.Windows.Forms.Label label7; // 563
        private System.Windows.Forms.Label label8; // 564
        private System.Windows.Forms.Label label9; // 565
        private System.Windows.Forms.Label label10; // 566
        private System.Windows.Forms.Label label11; // 567
        private System.Windows.Forms.Label label12; // 568
        private System.Windows.Forms.Label label13; // 569
        private System.Windows.Forms.Label label14; // 570
        private System.Windows.Forms.TextBox txtEmpCode; // 571
        private System.Windows.Forms.TextBox txtName; // 572
        private System.Windows.Forms.TextBox txtFatherName; // 573
        private System.Windows.Forms.TextBox txtMotherName; // 574
        private System.Windows.Forms.TextBox txtMobileNo; // 575
        private System.Windows.Forms.TextBox txtEmergencyContact; // 576
        private System.Windows.Forms.TextBox txtNationalId; // 577
        private System.Windows.Forms.DateTimePicker dtpDob; // 578
        private System.Windows.Forms.ComboBox cmbGender; // 579
        private System.Windows.Forms.ComboBox cmbMaritalStatus; // 580
        private System.Windows.Forms.TextBox txtPresentAddress; // 581
        private System.Windows.Forms.TextBox txtPermanentAddress; // 582
        private System.Windows.Forms.DateTimePicker dtpJoinDate; // 583
        private System.Windows.Forms.TextBox txtInitialSalary; // 584
        private System.Windows.Forms.PictureBox picPhoto; // 585
        private System.Windows.Forms.Button btnSelectImage; // 586
        private System.Windows.Forms.Button btnRemoveImage; // 587
        private System.Windows.Forms.Button btnNew; // 588
        private System.Windows.Forms.Button btnSave; // 589
        private System.Windows.Forms.Button btnGetData; // 590
        private System.Windows.Forms.Button btnUpDate; // 591
        private System.Windows.Forms.Button btnDelete; // 592
        private System.Windows.Forms.Button btnClose; // 593
        private System.Windows.Forms.TextBox txtNote; // 594
        private System.Windows.Forms.Label label15; // 595
        private System.Windows.Forms.Button btnF1; // 596
        private System.Windows.Forms.Label label16; // 597
        private System.Windows.Forms.TextBox txtShopCode; // 598
        private System.Windows.Forms.TextBox txtShopName; // 599
        private System.Windows.Forms.TextBox txtShopAddress; // 600
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    } // 601
} // 602
