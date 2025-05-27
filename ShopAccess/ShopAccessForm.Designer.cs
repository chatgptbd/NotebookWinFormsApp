namespace NotebookWinFormsApp // 1
{ // 2
    partial class ShopAccessForm // 3
    { // 4
        private System.ComponentModel.IContainer components = null; // 5
                                                                    // 6
        protected override void Dispose(bool disposing) // 7
        { // 8
            if (disposing && (components != null)) // 9
            { // 10
                components.Dispose(); // 11
            } // 12
            base.Dispose(disposing); // 13
        } // 14
          // 15
        #region Windows Form Designer generated code // 16
        // 17
        private void InitializeComponent() // 18
        { // 19
            this.lblPrompt = new System.Windows.Forms.Label(); // 20
            this.txtPassword = new System.Windows.Forms.TextBox(); // 21
            this.btnOK = new System.Windows.Forms.Button(); // 22
            this.btnCancel = new System.Windows.Forms.Button(); // 23
            this.SuspendLayout(); // 24
            //  // 25
            // lblPrompt // 26
            //  // 27
            this.lblPrompt.AutoSize = true; // 28
            this.lblPrompt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 29
            this.lblPrompt.Location = new System.Drawing.Point(25, 20); // 30
            this.lblPrompt.Name = "lblPrompt"; // 31
            this.lblPrompt.Size = new System.Drawing.Size(260, 19); // 32
            this.lblPrompt.TabIndex = 0; // 33
            this.lblPrompt.Text = "Enter Password to modify Shop List:"; // 34
            //  // 35
            // txtPassword // 36
            //  // 37
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 38
            this.txtPassword.Location = new System.Drawing.Point(25, 50); // 39
            this.txtPassword.Name = "txtPassword"; // 40
            this.txtPassword.PasswordChar = '*'; // 41
            this.txtPassword.Size = new System.Drawing.Size(260, 25); // 42
            this.txtPassword.TabIndex = 1; // 43
            //  // 44
            // btnOK // 45
            //  // 46
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 47
            this.btnOK.Location = new System.Drawing.Point(50, 90); // 48
            this.btnOK.Name = "btnOK"; // 49
            this.btnOK.Size = new System.Drawing.Size(80, 30); // 50
            this.btnOK.TabIndex = 2; // 51
            this.btnOK.Text = "OK"; // 52
            this.btnOK.UseVisualStyleBackColor = true; // 53
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click); // 54
            //  // 55
            // btnCancel // 56
            //  // 57
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); // 58
            this.btnCancel.Location = new System.Drawing.Point(170, 90); // 59
            this.btnCancel.Name = "btnCancel"; // 60
            this.btnCancel.Size = new System.Drawing.Size(80, 30); // 61
            this.btnCancel.TabIndex = 3; // 62
            this.btnCancel.Text = "Cancel"; // 63
            this.btnCancel.UseVisualStyleBackColor = true; // 64
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click); // 65
            //  // 66
            // ShopAccessForm // 67
            //  // 68
            this.AcceptButton = this.btnOK; // 69
            this.CancelButton = this.btnCancel; // 70
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F); // 71
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // 72
            this.ClientSize = new System.Drawing.Size(314, 140); // 73
            this.Controls.Add(this.btnCancel); // 74
            this.Controls.Add(this.btnOK); // 75
            this.Controls.Add(this.txtPassword); // 76
            this.Controls.Add(this.lblPrompt); // 77
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // 78
            this.MaximizeBox = false; // 79
            this.MinimizeBox = false; // 80
            this.Name = "ShopAccessForm"; // 81
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; // 82
            this.Text = "Shop Access"; // 83
            this.Load += new System.EventHandler(this.ShopAccessForm_Load); // 84
            this.ResumeLayout(false); // 85
            this.PerformLayout(); // 86
        } // 87
          // 88
        #endregion // 89
        // 90
        private System.Windows.Forms.Label lblPrompt; // 91
        private System.Windows.Forms.TextBox txtPassword; // 92
        private System.Windows.Forms.Button btnOK; // 93
        private System.Windows.Forms.Button btnCancel; // 94
    } // 95
} // 96
