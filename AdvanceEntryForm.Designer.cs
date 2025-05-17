namespace NotebookWinFormsApp
{
    partial class AdvanceEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtAmount = new System.Windows.Forms.TextBox();
            txtInstallment = new System.Windows.Forms.TextBox();
            dtpAdvanceDate = new System.Windows.Forms.DateTimePicker();
            btnNew = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnGetData = new System.Windows.Forms.Button();
            btnUpDate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dtpStartMonth = new System.Windows.Forms.DateTimePicker();
            txtNote = new System.Windows.Forms.TextBox();
            txtSearch = new System.Windows.Forms.TextBox();
            lstSuggestion = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(57, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(57, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Advance Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(57, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 21);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(57, 166);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 21);
            label4.TabIndex = 3;
            label4.Text = "Installment";
            // 
            // txtAmount
            // 
            txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAmount.Location = new System.Drawing.Point(173, 125);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new System.Drawing.Size(120, 29);
            txtAmount.TabIndex = 2;
            txtAmount.Text = "0.00";
            txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInstallment
            // 
            txtInstallment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtInstallment.Location = new System.Drawing.Point(173, 167);
            txtInstallment.Name = "txtInstallment";
            txtInstallment.Size = new System.Drawing.Size(120, 29);
            txtInstallment.TabIndex = 3;
            txtInstallment.Tag = "";
            txtInstallment.Text = "0.00";
            txtInstallment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpAdvanceDate
            // 
            dtpAdvanceDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpAdvanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpAdvanceDate.Location = new System.Drawing.Point(173, 88);
            dtpAdvanceDate.Name = "dtpAdvanceDate";
            dtpAdvanceDate.Size = new System.Drawing.Size(123, 29);
            dtpAdvanceDate.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNew.Location = new System.Drawing.Point(553, 52);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 33);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(553, 102);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 33);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnGetData
            // 
            btnGetData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGetData.Location = new System.Drawing.Point(553, 147);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new System.Drawing.Size(94, 33);
            btnGetData.TabIndex = 8;
            btnGetData.Text = "GetData";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // btnUpDate
            // 
            btnUpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpDate.Location = new System.Drawing.Point(553, 193);
            btnUpDate.Name = "btnUpDate";
            btnUpDate.Size = new System.Drawing.Size(94, 33);
            btnUpDate.TabIndex = 9;
            btnUpDate.Text = "UpDate";
            btnUpDate.UseVisualStyleBackColor = true;
            btnUpDate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(553, 236);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 33);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(553, 285);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 33);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(57, 211);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(92, 21);
            label5.TabIndex = 14;
            label5.Text = "Start Month";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(57, 246);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 21);
            label6.TabIndex = 15;
            label6.Text = "Note";
            // 
            // dtpStartMonth
            // 
            dtpStartMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpStartMonth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpStartMonth.Location = new System.Drawing.Point(173, 208);
            dtpStartMonth.Name = "dtpStartMonth";
            dtpStartMonth.Size = new System.Drawing.Size(123, 29);
            dtpStartMonth.TabIndex = 4;
            // 
            // txtNote
            // 
            txtNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNote.Location = new System.Drawing.Point(173, 247);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new System.Drawing.Size(327, 50);
            txtNote.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(173, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(327, 29);
            txtSearch.TabIndex = 0;
            // 
            // lstSuggestion
            // 
            lstSuggestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstSuggestion.FormattingEnabled = true;
            lstSuggestion.ItemHeight = 21;
            lstSuggestion.Location = new System.Drawing.Point(174, 74);
            lstSuggestion.Name = "lstSuggestion";
            lstSuggestion.Size = new System.Drawing.Size(289, 88);
            lstSuggestion.TabIndex = 1;
            lstSuggestion.Visible = false;
            // 
            // AdvanceEntryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(684, 366);
            Controls.Add(lstSuggestion);
            Controls.Add(txtSearch);
            Controls.Add(txtNote);
            Controls.Add(dtpStartMonth);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpDate);
            Controls.Add(btnGetData);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(dtpAdvanceDate);
            Controls.Add(txtInstallment);
            Controls.Add(txtAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "AdvanceEntryForm";
            Text = "AdvenceEntryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtInstallment;
        private System.Windows.Forms.DateTimePicker dtpAdvanceDate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartMonth;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstSuggestion;
    }
}