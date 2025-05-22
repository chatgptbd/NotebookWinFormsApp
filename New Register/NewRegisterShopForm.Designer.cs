namespace NotebookWinFormsApp // 1
{ // 2
    partial class NewRegisterShopForm // 3
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
            bntClose = new System.Windows.Forms.Button(); // 31
            btnDelete = new System.Windows.Forms.Button(); // 32
            btnUpdate = new System.Windows.Forms.Button(); // 33
            btnGetData = new System.Windows.Forms.Button(); // 34
            btnSave = new System.Windows.Forms.Button(); // 35
            btnNew = new System.Windows.Forms.Button(); // 36
            dtpOpeningDate = new System.Windows.Forms.DateTimePicker(); // 37
            cmbStatus = new System.Windows.Forms.ComboBox(); // 38
            cmbShopType = new System.Windows.Forms.ComboBox(); // 39
            txtLicenseNo = new System.Windows.Forms.TextBox(); // 40
            txtEmail = new System.Windows.Forms.TextBox(); // 41
            txtAddress = new System.Windows.Forms.TextBox(); // 42
            txtMobile = new System.Windows.Forms.TextBox(); // 43
            txtOwnerName = new System.Windows.Forms.TextBox(); // 44
            txtShopName = new System.Windows.Forms.TextBox(); // 45
            txtShopCode = new System.Windows.Forms.TextBox(); // 46
            label10 = new System.Windows.Forms.Label(); // 47
            label9 = new System.Windows.Forms.Label(); // 48
            label8 = new System.Windows.Forms.Label(); // 49
            label7 = new System.Windows.Forms.Label(); // 50
            label6 = new System.Windows.Forms.Label(); // 51
            label5 = new System.Windows.Forms.Label(); // 52
            label4 = new System.Windows.Forms.Label(); // 53
            label3 = new System.Windows.Forms.Label(); // 54
            label2 = new System.Windows.Forms.Label(); // 55
            label1 = new System.Windows.Forms.Label(); // 56
            SuspendLayout(); // 57
            // // 58
            // bntClose // 59
            // // 60
            bntClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 61
            bntClose.Location = new System.Drawing.Point(534, 251); // 62
            bntClose.Name = "bntClose"; // 63
            bntClose.Size = new System.Drawing.Size(75, 30); // 64
            bntClose.TabIndex = 14; // 65
            bntClose.Text = "Close"; // 66
            bntClose.UseVisualStyleBackColor = true; // 67
            // // 68
            // btnDelete // 69
            // // 70
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 71
            btnDelete.Location = new System.Drawing.Point(534, 209); // 72
            btnDelete.Name = "btnDelete"; // 73
            btnDelete.Size = new System.Drawing.Size(75, 30); // 74
            btnDelete.TabIndex = 13; // 75
            btnDelete.Text = "Delete"; // 76
            btnDelete.UseVisualStyleBackColor = true; // 77
            btnDelete.Click += btnDelete_Click; // 78
            // // 79
            // btnUpdate // 80
            // // 81
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 82
            btnUpdate.Location = new System.Drawing.Point(534, 167); // 83
            btnUpdate.Name = "btnUpdate"; // 84
            btnUpdate.Size = new System.Drawing.Size(75, 30); // 85
            btnUpdate.TabIndex = 12; // 86
            btnUpdate.Text = "Update"; // 87
            btnUpdate.UseVisualStyleBackColor = true; // 88
            btnUpdate.Click += btnUpdate_Click; // 89
            // // 90
            // btnGetData // 91
            // // 92
            btnGetData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 93
            btnGetData.Location = new System.Drawing.Point(534, 126); // 94
            btnGetData.Name = "btnGetData"; // 95
            btnGetData.Size = new System.Drawing.Size(75, 30); // 96
            btnGetData.TabIndex = 11; // 97
            btnGetData.Text = "GetData"; // 98
            btnGetData.UseVisualStyleBackColor = true; // 99
            btnGetData.Click += btnGetData_Click; // 100
            // // 101
            // btnSave // 102
            // // 103
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 104
            btnSave.Location = new System.Drawing.Point(534, 85); // 105
            btnSave.Name = "btnSave"; // 106
            btnSave.Size = new System.Drawing.Size(75, 30); // 107
            btnSave.TabIndex = 10; // 108
            btnSave.Text = "Save"; // 109
            btnSave.UseVisualStyleBackColor = true; // 110
            btnSave.Click += btnSave_Click; // 111
            // // 112
            // btnNew // 113
            // // 114
            btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 115
            btnNew.Location = new System.Drawing.Point(534, 44); // 116
            btnNew.Name = "btnNew"; // 117
            btnNew.Size = new System.Drawing.Size(75, 30); // 118
            btnNew.TabIndex = 9; // 119
            btnNew.Text = "New"; // 120
            btnNew.UseVisualStyleBackColor = true; // 121
            btnNew.Click += btnNew_Click; // 122
            // // 123
            // dtpOpeningDate // 124
            // // 125
            dtpOpeningDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 126
            dtpOpeningDate.Location = new System.Drawing.Point(150, 322); // 127
            dtpOpeningDate.Name = "dtpOpeningDate"; // 128
            dtpOpeningDate.Size = new System.Drawing.Size(181, 29); // 129
            dtpOpeningDate.TabIndex = 6; // 130
            // // 131
            // cmbStatus // 132
            // // 133
            cmbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 134
            cmbStatus.FormattingEnabled = true; // 135
            cmbStatus.Location = new System.Drawing.Point(150, 392); // 136
            cmbStatus.Name = "cmbStatus"; // 137
            cmbStatus.Size = new System.Drawing.Size(121, 29); // 138
            cmbStatus.TabIndex = 8; // 139
            // // 140
            // cmbShopType // 141
            // // 142
            cmbShopType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 143
            cmbShopType.FormattingEnabled = true; // 144
            cmbShopType.Location = new System.Drawing.Point(150, 287); // 145
            cmbShopType.Name = "cmbShopType"; // 146
            cmbShopType.Size = new System.Drawing.Size(148, 29); // 147
            cmbShopType.TabIndex = 5; // 148
            // // 149
            // txtLicenseNo // 150
            // // 151
            txtLicenseNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 152
            txtLicenseNo.Location = new System.Drawing.Point(150, 357); // 153
            txtLicenseNo.Name = "txtLicenseNo"; // 154
            txtLicenseNo.Size = new System.Drawing.Size(338, 29); // 155
            txtLicenseNo.TabIndex = 7; // 156
            // // 157
            // txtEmail // 158
            // // 159
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 160
            txtEmail.Location = new System.Drawing.Point(150, 252); // 161
            txtEmail.Name = "txtEmail"; // 162
            txtEmail.Size = new System.Drawing.Size(338, 29); // 163
            txtEmail.TabIndex = 4; // 164
            // // 165
            // txtAddress // 166
            // // 167
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 168
            txtAddress.Location = new System.Drawing.Point(150, 165); // 169
            txtAddress.Multiline = true; // 170
            txtAddress.Name = "txtAddress"; // 171
            txtAddress.Size = new System.Drawing.Size(338, 79); // 172
            txtAddress.TabIndex = 3; // 173
            // // 174
            // txtMobile // 175
            // // 176
            txtMobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 177
            txtMobile.Location = new System.Drawing.Point(150, 129); // 178
            txtMobile.Name = "txtMobile"; // 179
            txtMobile.Size = new System.Drawing.Size(338, 29); // 180
            txtMobile.TabIndex = 2; // 181
            // // 182
            // txtOwnerName // 183
            // // 184
            txtOwnerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 185
            txtOwnerName.Location = new System.Drawing.Point(150, 93); // 186
            txtOwnerName.Name = "txtOwnerName"; // 187
            txtOwnerName.Size = new System.Drawing.Size(338, 29); // 188
            txtOwnerName.TabIndex = 1; // 189
            // // 190
            // txtShopName // 191
            // // 192
            txtShopName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 193
            txtShopName.Location = new System.Drawing.Point(150, 58); // 194
            txtShopName.Name = "txtShopName"; // 195
            txtShopName.Size = new System.Drawing.Size(338, 29); // 196
            txtShopName.TabIndex = 0; // 197
            // // 198
            // txtShopCode // 199
            // // 200
            txtShopCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 201
            txtShopCode.Location = new System.Drawing.Point(150, 21); // 202
            txtShopCode.Name = "txtShopCode"; // 203
            txtShopCode.ReadOnly = true; // 204
            txtShopCode.Size = new System.Drawing.Size(338, 29); // 205
            txtShopCode.TabIndex = 36; // 206
            // // 207
            // label10 // 208
            // // 209
            label10.AutoSize = true; // 210
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 211
            label10.Location = new System.Drawing.Point(29, 400); // 212
            label10.Name = "label10"; // 213
            label10.Size = new System.Drawing.Size(52, 21); // 214
            label10.TabIndex = 35; // 215
            label10.Text = "Status"; // 216
            // // 217
            // label9 // 218
            // // 219
            label9.AutoSize = true; // 220
            label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 221
            label9.Location = new System.Drawing.Point(29, 365); // 222
            label9.Name = "label9"; // 223
            label9.Size = new System.Drawing.Size(86, 21); // 224
            label9.TabIndex = 34; // 225
            label9.Text = "License No"; // 226
            // // 227
            // label8 // 228
            // // 229
            label8.AutoSize = true; // 230
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 231
            label8.Location = new System.Drawing.Point(29, 330); // 232
            label8.Name = "label8"; // 233
            label8.Size = new System.Drawing.Size(106, 21); // 234
            label8.TabIndex = 33; // 235
            label8.Text = "Opening Date"; // 236
            // // 237
            // label7 // 238
            // // 239
            label7.AutoSize = true; // 240
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 241
            label7.Location = new System.Drawing.Point(29, 296); // 242
            label7.Name = "label7"; // 243
            label7.Size = new System.Drawing.Size(82, 21); // 244
            label7.TabIndex = 32; // 245
            label7.Text = "Shop Type"; // 246
            // // 247
            // label6 // 248
            // // 249
            label6.AutoSize = true; // 250
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 251
            label6.Location = new System.Drawing.Point(29, 261); // 252
            label6.Name = "label6"; // 253
            label6.Size = new System.Drawing.Size(48, 21); // 254
            label6.TabIndex = 31; // 255
            label6.Text = "Email"; // 256
            // // 257
            // label5 // 258
            // // 259
            label5.AutoSize = true; // 260
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 261
            label5.Location = new System.Drawing.Point(29, 168); // 262
            label5.Name = "label5"; // 263
            label5.Size = new System.Drawing.Size(66, 21); // 264
            label5.TabIndex = 30; // 265
            label5.Text = "Address"; // 266
            // // 267
            // label4 // 268
            // // 269
            label4.AutoSize = true; // 270
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 271
            label4.Location = new System.Drawing.Point(29, 133); // 272
            label4.Name = "label4"; // 273
            label4.Size = new System.Drawing.Size(58, 21); // 274
            label4.TabIndex = 29; // 275
            label4.Text = "Mobile"; // 276
            // // 277
            // label3 // 278
            // // 279
            label3.AutoSize = true; // 280
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 281
            label3.Location = new System.Drawing.Point(29, 102); // 282
            label3.Name = "label3"; // 283
            label3.Size = new System.Drawing.Size(103, 21); // 284
            label3.TabIndex = 28; // 285
            label3.Text = "Owner Name"; // 286
            // // 287
            // label2 // 288
            // // 289
            label2.AutoSize = true; // 290
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 291
            label2.Location = new System.Drawing.Point(29, 67); // 292
            label2.Name = "label2"; // 293
            label2.Size = new System.Drawing.Size(92, 21); // 294
            label2.TabIndex = 27; // 295
            label2.Text = "Shop Name"; // 296
            // // 297
            // label1 // 298
            // // 299
            label1.AutoSize = true; // 300
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 301
            label1.Location = new System.Drawing.Point(29, 30); // 302
            label1.Name = "label1"; // 303
            label1.Size = new System.Drawing.Size(86, 21); // 304
            label1.TabIndex = 26; // 305
            label1.Text = "Shop Code"; // 306
            // // 307
            // NewRegisterShopForm // 308
            // // 309
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F); // 310
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // 311
            ClientSize = new System.Drawing.Size(646, 450); // 312
            Controls.Add(bntClose); // 313
            Controls.Add(btnDelete); // 314
            Controls.Add(btnUpdate); // 315
            Controls.Add(btnGetData); // 316
            Controls.Add(btnSave); // 317
            Controls.Add(btnNew); // 318
            Controls.Add(dtpOpeningDate); // 319
            Controls.Add(cmbStatus); // 320
            Controls.Add(cmbShopType); // 321
            Controls.Add(txtLicenseNo); // 322
            Controls.Add(txtEmail); // 323
            Controls.Add(txtAddress); // 324
            Controls.Add(txtMobile); // 325
            Controls.Add(txtOwnerName); // 326
            Controls.Add(txtShopName); // 327
            Controls.Add(txtShopCode); // 328
            Controls.Add(label10); // 329
            Controls.Add(label9); // 330
            Controls.Add(label8); // 331
            Controls.Add(label7); // 332
            Controls.Add(label6); // 333
            Controls.Add(label5); // 334
            Controls.Add(label4); // 335
            Controls.Add(label3); // 336
            Controls.Add(label2); // 337
            Controls.Add(label1); // 338
            Name = "NewRegisterShopForm"; // 339
            Text = "NewRegisterShopForm"; // 340
            Load += NewRegisterShopForm_Load; // 341
            ResumeLayout(false); // 342
            PerformLayout(); // 343
        } // 344
          // 345
        #endregion // 346
        // 347
        private System.Windows.Forms.Button bntClose; // 348
        private System.Windows.Forms.Button btnDelete; // 349
        private System.Windows.Forms.Button btnUpdate; // 350
        private System.Windows.Forms.Button btnGetData; // 351
        private System.Windows.Forms.Button btnSave; // 352
        private System.Windows.Forms.Button btnNew; // 353
        private System.Windows.Forms.DateTimePicker dtpOpeningDate; // 354
        private System.Windows.Forms.ComboBox cmbStatus; // 355
        private System.Windows.Forms.ComboBox cmbShopType; // 356
        private System.Windows.Forms.TextBox txtLicenseNo; // 357
        private System.Windows.Forms.TextBox txtEmail; // 358
        private System.Windows.Forms.TextBox txtAddress; // 359
        private System.Windows.Forms.TextBox txtMobile; // 360
        private System.Windows.Forms.TextBox txtOwnerName; // 361
        private System.Windows.Forms.TextBox txtShopName; // 362
        private System.Windows.Forms.TextBox txtShopCode; // 363
        private System.Windows.Forms.Label label10; // 364
        private System.Windows.Forms.Label label9; // 365
        private System.Windows.Forms.Label label8; // 366
        private System.Windows.Forms.Label label7; // 367
        private System.Windows.Forms.Label label6; // 368
        private System.Windows.Forms.Label label5; // 369
        private System.Windows.Forms.Label label4; // 370
        private System.Windows.Forms.Label label3; // 371
        private System.Windows.Forms.Label label2; // 372
        private System.Windows.Forms.Label label1; // 373
    } // 374
} // 375
