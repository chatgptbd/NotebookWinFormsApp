namespace NotebookWinFormsApp // 1
{ // 2
    partial class EmployeeListForm // 3
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
            dataGridView1 = new System.Windows.Forms.DataGridView(); // 31
            ColSerial = new System.Windows.Forms.DataGridViewTextBoxColumn(); // 32
            ColEmpCode = new System.Windows.Forms.DataGridViewTextBoxColumn(); // 33
            ColName = new System.Windows.Forms.DataGridViewTextBoxColumn(); // 34
            ColMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn(); // 35
            ColJointDate = new System.Windows.Forms.DataGridViewTextBoxColumn(); // 36
            ColInitialSalary = new System.Windows.Forms.DataGridViewTextBoxColumn(); // 37
            ColMaritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn(); // 38
            ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn(); // 39
            txtSearchName = new System.Windows.Forms.TextBox(); // 40
            txtSearchMobileNo = new System.Windows.Forms.TextBox(); // 41
            label1 = new System.Windows.Forms.Label(); // 42
            label2 = new System.Windows.Forms.Label(); // 43
            picPhoto = new System.Windows.Forms.PictureBox(); // 44
            txtPresentAddress = new System.Windows.Forms.TextBox(); // 45
            txtPermanentAddress = new System.Windows.Forms.TextBox(); // 46
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit(); // 47
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit(); // 48
            SuspendLayout(); // 49
            // // 50
            // dataGridView1 // 51
            // // 52
            dataGridView1.AllowUserToAddRows = false; // 53
            dataGridView1.AllowUserToDeleteRows = false; // 54
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize; // 55
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColSerial, ColEmpCode, ColName, ColMobileNo, ColJointDate, ColInitialSalary, ColMaritalStatus, ColGender }); // 56
            dataGridView1.Location = new System.Drawing.Point(17, 47); // 57
            dataGridView1.Name = "dataGridView1"; // 58
            dataGridView1.ReadOnly = true; // 59
            dataGridView1.RowTemplate.Height = 25; // 60
            dataGridView1.Size = new System.Drawing.Size(854, 399); // 61
            dataGridView1.TabIndex = 3; // 62
            // // 63
            // ColSerial // 64
            // // 65
            ColSerial.DataPropertyName = "Serial"; // 66
            ColSerial.HeaderText = "Serial"; // 67
            ColSerial.Name = "ColSerial"; // 68
            ColSerial.ReadOnly = true; // 69
            // // 70
            // ColEmpCode // 71
            // // 72
            ColEmpCode.DataPropertyName = "EmpCode"; // 73
            ColEmpCode.HeaderText = "EmpCode"; // 74
            ColEmpCode.Name = "ColEmpCode"; // 75
            ColEmpCode.ReadOnly = true; // 76
            // // 77
            // ColName // 78
            // // 79
            ColName.DataPropertyName = "Name"; // 80
            ColName.HeaderText = "Name"; // 81
            ColName.Name = "ColName"; // 82
            ColName.ReadOnly = true; // 83
            // // 84
            // ColMobileNo // 85
            // // 86
            ColMobileNo.DataPropertyName = "MobileNo"; // 87
            ColMobileNo.HeaderText = "Mobile No"; // 88
            ColMobileNo.Name = "ColMobileNo"; // 89
            ColMobileNo.ReadOnly = true; // 90
            // // 91
            // ColJointDate // 92
            // // 93
            ColJointDate.DataPropertyName = "JointDate"; // 94
            ColJointDate.HeaderText = "JointDate"; // 95
            ColJointDate.Name = "ColJointDate"; // 96
            ColJointDate.ReadOnly = true; // 97
            // // 98
            // ColInitialSalary // 99
            // // 100
            ColInitialSalary.DataPropertyName = "Salary"; // 101
            ColInitialSalary.HeaderText = "Salary"; // 102
            ColInitialSalary.Name = "ColInitialSalary"; // 103
            ColInitialSalary.ReadOnly = true; // 104
            // // 105
            // ColMaritalStatus // 106
            // // 107
            ColMaritalStatus.DataPropertyName = "Marital"; // 108
            ColMaritalStatus.HeaderText = "Marital"; // 109
            ColMaritalStatus.Name = "ColMaritalStatus"; // 110
            ColMaritalStatus.ReadOnly = true; // 111
            // // 112
            // ColGender // 113
            // // 114
            ColGender.DataPropertyName = "Gender"; // 115
            ColGender.HeaderText = "Gender"; // 116
            ColGender.Name = "ColGender"; // 117
            ColGender.ReadOnly = true; // 118
            // // 119
            // txtSearchName // 120
            // // 121
            txtSearchName.Location = new System.Drawing.Point(98, 12); // 122
            txtSearchName.Name = "txtSearchName"; // 123
            txtSearchName.Size = new System.Drawing.Size(167, 23); // 124
            txtSearchName.TabIndex = 0; // 125
            // // 126
            // txtSearchMobileNo // 127
            // // 128
            txtSearchMobileNo.Location = new System.Drawing.Point(405, 13); // 129
            txtSearchMobileNo.Name = "txtSearchMobileNo"; // 130
            txtSearchMobileNo.Size = new System.Drawing.Size(177, 23); // 131
            txtSearchMobileNo.TabIndex = 1; // 132
            // // 133
            // label1 // 134
            // // 135
            label1.AutoSize = true; // 136
            label1.Location = new System.Drawing.Point(12, 16); // 137
            label1.Name = "label1"; // 138
            label1.Size = new System.Drawing.Size(77, 15); // 139
            label1.TabIndex = 8; // 140
            label1.Text = "Search Name"; // 141
            // // 142
            // label2 // 143
            // // 144
            label2.AutoSize = true; // 145
            label2.Location = new System.Drawing.Point(290, 17); // 146
            label2.Name = "label2"; // 147
            label2.Size = new System.Drawing.Size(101, 15); // 148
            label2.TabIndex = 9; // 149
            label2.Text = "Search Mobile No"; // 150
            // // 151
            // picPhoto // 152
            // // 153
            picPhoto.Location = new System.Drawing.Point(891, 56); // 154
            picPhoto.Name = "picPhoto"; // 155
            picPhoto.Size = new System.Drawing.Size(122, 74); // 156
            picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // 157
            picPhoto.TabIndex = 10; // 158
            picPhoto.TabStop = false; // 159
            // // 160
            // txtPresentAddress // 161
            // // 162
            txtPresentAddress.Location = new System.Drawing.Point(891, 183); // 163
            txtPresentAddress.Multiline = true; // 164
            txtPresentAddress.Name = "txtPresentAddress"; // 165
            txtPresentAddress.ReadOnly = true; // 166
            txtPresentAddress.Size = new System.Drawing.Size(132, 49); // 167
            txtPresentAddress.TabIndex = 11; // 168
            // // 169
            // txtPermanentAddress // 170
            // // 171
            txtPermanentAddress.Location = new System.Drawing.Point(891, 249); // 172
            txtPermanentAddress.Multiline = true; // 173
            txtPermanentAddress.Name = "txtPermanentAddress"; // 174
            txtPermanentAddress.ReadOnly = true; // 175
            txtPermanentAddress.Size = new System.Drawing.Size(132, 55); // 176
            txtPermanentAddress.TabIndex = 12; // 177
            // // 178
            // EmployeeListForm // 179
            // // 180
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F); // 181
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // 182
            ClientSize = new System.Drawing.Size(1035, 450); // 183
            Controls.Add(txtPermanentAddress); // 184
            Controls.Add(txtPresentAddress); // 185
            Controls.Add(picPhoto); // 186
            Controls.Add(label2); // 187
            Controls.Add(label1); // 188
            Controls.Add(txtSearchMobileNo); // 189
            Controls.Add(txtSearchName); // 190
            Controls.Add(dataGridView1); // 191
            Name = "EmployeeListForm"; // 192
            Text = "EmployeeList"; // 193
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit(); // 194
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit(); // 195
            ResumeLayout(false); // 196
            PerformLayout(); // 197
        } // 198
          // 199
        #endregion // 200
        // 201
        private System.Windows.Forms.DataGridView dataGridView1; // 202
        private System.Windows.Forms.TextBox txtSearchName; // 203
        private System.Windows.Forms.TextBox txtSearchMobileNo; // 204
        private System.Windows.Forms.Label label1; // 205
        private System.Windows.Forms.Label label2; // 206
        private System.Windows.Forms.PictureBox picPhoto; // 207
        private System.Windows.Forms.TextBox txtPresentAddress; // 208
        private System.Windows.Forms.TextBox txtPermanentAddress; // 209
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSerial; // 210
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpCode; // 211
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName; // 212
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobileNo; // 213
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJointDate; // 214
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInitialSalary; // 215
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaritalStatus; // 216
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender; // 217
    } // 218
} // 219
